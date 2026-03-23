namespace lesson2.work_by_yourself
{
    internal class task4
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 10;

            Circle с2 = new Circle();
            с2.Radius = 20;

            Console.WriteLine("Площадь первого круга с радиусом 10: " + c1.GetArea());

            Console.WriteLine("Площадь первого круга с радиусом 20: " + с2.GetArea());
        }
    }
    class Circle
    {
        static readonly double PI = 3.14159;

        public int Radius;

        public double GetArea()
        {

            return PI * (Radius * Radius);
        }
    }
}