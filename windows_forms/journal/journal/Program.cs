using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HtmlAgilityPack;
using System.Security.Cryptography.X509Certificates;

namespace journal
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            //Application.Run(new MainWindow());
        }
    }

    public class Parser
    {
        public static string name;
        public static string grade;
        public static string rating;
        public static string allHomeWorks;
        public static string checkedHomeWorks;
        public static string passedHomeWorks;
        public static string deletedHomeWorks;
        public static string gems;
        public static string coins;

        private static string url = "https://journal.top-academy.ru/ru/auth/login/index?returnUrl=%2Fru%2Fmain%2Fdashboard%2Fpage%2Findex";
        private static string login;
        private static string password;

        public static bool GetAccess(string login, string password)
        {
            Parser.login = login;
            Parser.password = password;

            var options = new ChromeOptions();
            options.AddArgument("--headless");
            var driver = new ChromeDriver(options);

            try
            {
                driver.Navigate().GoToUrl(url);
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));

                var inputs = wait.Until(d => d.FindElements(By.TagName("input")));
                inputs[0].SendKeys(login);
                inputs[1].SendKeys(password);

                var buttons = driver.FindElements(By.TagName("button"));
                if (buttons.Any())
                {
                    buttons[0].Click();
                }
                Thread.Sleep(3000);

                if (driver.Url.Contains("login"))
                {
                    throw new Exception();
                }

                string htmlData = driver.PageSource;
                File.WriteAllText("page.html", htmlData);

                driver.Quit();
                return true;
            }
            catch (Exception e)
            {
                driver.Quit();
                return false;
            }
        }

        public static void getData()
        {
            string htmlData = File.ReadAllText("page.html");
            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(htmlData);

            var nameElement = doc.DocumentNode.SelectSingleNode("//div[@class='top-panel__profile-name']");
            name = nameElement.InnerText.Trim();

            var coinsElement = doc.DocumentNode.SelectNodes("//span[@class='wrap-counts']//span[@class='count-item']");
            gems = coinsElement[0].InnerText.Trim();
            coins = coinsElement[0].InnerText.Trim();

            var homeworkStats = doc.DocumentNode.SelectNodes("//div[@class='homeworks-content']//div[@class='item']//span");
            checkedHomeWorks = homeworkStats[1].InnerText.Trim();
            passedHomeWorks = homeworkStats[2].InnerText.Trim();
            deletedHomeWorks = homeworkStats[3].InnerText.Trim();

            var allHomeWorksElement = doc.DocumentNode.SelectSingleNode("//div[@class='count-block']/span[@class='all-count']");
            allHomeWorks = allHomeWorksElement.InnerText.Trim();

            var ratingElement = doc.DocumentNode.SelectSingleNode("//div[@class='rating rating-group']/div[@class='rating-position']");
            rating = ratingElement.InnerText.Trim();

            var gradeElement = doc.DocumentNode.SelectSingleNode("//div[@class='col-md-4 progress-info-count']/span[@class='middle_count']");
            grade = gradeElement.InnerText.Trim();
        }

        public static void Update()
        {
            GetAccess(login, password);
            getData();
        }
    }
}