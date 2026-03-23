namespace get_set
{
    internal class @base
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

class City
{
    private int _population;

    public string CityName {get;}

    public int Area { get; set;}

    public int Population
    {
        get {return _population;}
        set { if (value > 0) _population = value; }
    }

    public City(int population, string cityName, int area)
    {
        Population = population;
        CityName = cityName;
        Area = area;
    }
}