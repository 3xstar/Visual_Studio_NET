namespace abstracts
{
    internal class task1
    {
        static void Main1(string[] args)
        {
            Figure c1 = new Circle(10);
            Figure r1 = new Rectangle(10, 20);
            Figure c2 = new Circle(30);
            Figure r2 = new Rectangle(50, 40);

            Figure[] arr = { c1, r1, c2, r2 };

            foreach (Figure f in arr)
            {
                f.printInfo();
                Console.WriteLine("\n");
            }
        }

        abstract class Figure
        {
            public abstract string type_of_figure();

            public abstract double getArea();

            public abstract double getPerimeter();

            public void printInfo()
            {
                Console.WriteLine($"Тип фигуры: {type_of_figure()}\n" +
                    $"Площадь фигуры: {getArea()}\n" +
                    $"Периметр фигуры: {getPerimeter()}");
            }

        }

        class Circle : Figure
        {
            private int radius;

            public Circle(int r)
            {
                radius = r;
            }

            public override string type_of_figure()
            {
                return "Круг";
            }

            public override double getArea()
            {
                return 3.14 * (radius * radius);
            }

            public override double getPerimeter()
            {
                return 2 * 3.14 * radius;
            }
        }

        class Rectangle : Figure
        {
            private int weight;
            private int height;

            public Rectangle(int w, int h)
            {
                weight = w;
                height = h;
            }

            public override string type_of_figure()
            {
                return "Прямоугольник";
            }

            public override double getArea()
            {
                return weight * height;
            }

            public override double getPerimeter()
            {
                return (weight * 2) + (height * 2);
            }
        }

    }
}
