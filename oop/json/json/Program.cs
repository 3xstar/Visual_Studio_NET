using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.IO;

namespace json
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("X5", 2025, "BMW");
            Car car2 = new Car("X4", 2025, "BMW");
            Car car3 = new Car("X3", 2025, "BMW");

            string jsonString = JsonConvert.SerializeObject(car1, Formatting.Indented);
            string path = @"C:\testProgram\car1.json";

            File.WriteAllText(path, jsonString);

            List<Car> cars = new List<Car> { car1, car2, car3 };
            string carsJson = JsonConvert.SerializeObject(cars, Formatting.Indented);

            string carsPath = @"C:\testProgram\cars.json";
            File.WriteAllText(carsPath, carsJson);

            Dictionary<string, int> prices = new Dictionary<string, int>
            {
                { "car1", 50000 },
                { "car2", 45000 },
                { "car3", 40000 }
            };

            string pricesJson = JsonConvert.SerializeObject(prices, Formatting.Indented);

            string pricesPath = @"C:\testProgram\prices.json";
            File.WriteAllText(pricesPath, pricesJson);

            // Чтение из файла и десериализация
            string jsonFromFile = File.ReadAllText(path);
            Car newCar = JsonConvert.DeserializeObject<Car>(jsonFromFile);
            Console.WriteLine($"Model: {newCar.Model}, Year: {newCar.Year}, Mark: {newCar.Mark}");

            // Чтение из файла и десериализация списка
            string jsonFromFile2 = File.ReadAllText(carsPath);
            List<Car> newCars = JsonConvert.DeserializeObject<List<Car>>(jsonFromFile2);
            foreach (Car car in newCars)
            {
                Console.WriteLine($"Model: {car.Model}, Year: {car.Year}, Mark: {car.Mark}");
            }

            // Чтение из файла и десериализация словаря
            string jsonFromFile3 = File.ReadAllText(pricesPath);
            Dictionary<string, int> newPrices = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonFromFile3);
            foreach (var kvp in newPrices)
            {
                Console.WriteLine($"Car: {kvp.Key}, Price: {kvp.Value}");
            }

        }
    }

    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public string Mark { get; set; }

        public Car(string model, int year, string mark)
        {
            Model = model;
            Year = year;
            Mark = mark;
        }

    }
}