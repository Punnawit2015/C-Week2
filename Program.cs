using System;

namespace C_Week2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            float radius;
            string NameofShape;
            double pi = 3.14;
            double ans;
            double Read_ans;

            Console.Write("Input your Shape");
            NameofShape = Console.ReadLine();
            float side;
            float length, width;
            float baseLength, height;
            float parallel1, parallel2;
            float plus_of_parallel;
            float diagonal_line, perimeter_square;


            if (NameofShape == "Circle")
            {
                Console.Write("Input the radius of the Circle: ");
                radius = float.Parse(Console.ReadLine());
                ans = pi * radius * radius;
                Console.WriteLine("The area of the Circle is: " + ans);
            }
            else if (NameofShape == "Square")
            {
                Console.Write("Input the side length of the Square: ");
                side = float.Parse(Console.ReadLine());
                ans = side * side;
                Console.WriteLine("The area of the Square is: " + ans);
            }

            else if (NameofShape == "Rectangle")
            {
                Console.Write("Input the length of the Rectangle: ");
                length = float.Parse(Console.ReadLine());
                Console.Write("Input the width of the Rectangle: ");
                width = float.Parse(Console.ReadLine());
                ans = length * width;
                Console.WriteLine("The area of the Rectangle is: " + ans);
            }
            else if (NameofShape == "Triangle")
            {
                Console.Write("Input the base length of the Triangle: ");
                baseLength = float.Parse(Console.ReadLine());
                Console.Write("Input the height of the Triangle: ");
                height = float.Parse(Console.ReadLine());
                ans = 0.5 * baseLength * height;
                Console.WriteLine("The area of the Triangle is: " + ans);
            }
            else if (NameofShape == "Paraell Triangle")
            {
                Console.Write("Input the base length of the Paraell Triangle: ");
                baseLength = float.Parse(Console.ReadLine());
                Console.Write("Input the height of the Paraell Triangle: ");
                height = float.Parse(Console.ReadLine());
                ans = baseLength * height;
                Console.WriteLine("The area of the Paraell Triangle is: " + ans);

            }
            else if (NameofShape == "Rombus")
            {
                Console.Write("Input the parallel1 of the Rombus: ");
                parallel1 = float.Parse(Console.ReadLine());
                Console.Write("Input the parallel2 of the Rombus: ");
                parallel2 = float.Parse(Console.ReadLine());
                ans = parallel1 * parallel2;
                Read_ans = 0.5 * ans;
                Console.WriteLine("The area of the Rombus is: " + Read_ans);
            }
            else if (NameofShape == "Isosceles Triangle")
            {
                Console.Write("Input the parallel1 of the Isosceles Triangle: ");

                parallel1 = float.Parse(Console.ReadLine());
                Console.Write("Input the parallel2 of the Isosceles Triangle: ");
                parallel2 = float.Parse(Console.ReadLine());
                Console.Write("Input the height of the Isosceles Triangle: ");
                height = float.Parse(Console.ReadLine());
                plus_of_parallel = parallel1 + parallel2;
                ans = 0.5 * plus_of_parallel * height;
                Console.WriteLine("The area of the Isosceles Triangle is: " + ans);
            }
            else if (NameofShape == "kite")
            {
                Console.Write("Input the parallel1 of the kite: ");
                parallel1 = float.Parse(Console.ReadLine());
                Console.Write("Input the parallel2 of the kite: ");
                parallel2 = float.Parse(Console.ReadLine());
                Read_ans = parallel1 * parallel2;
                ans = 0.5 * Read_ans;
                Console.WriteLine("The area of the kite is: " + ans);
            }

            else if (NameofShape == "Trapizod")
            {
                Console.Write("Input the diagonal_line of the Trapizod: ");
                diagonal_line = float.Parse(Console.ReadLine());
                Console.Write("Input the perimeter_square of the Trapizod: ");
                perimeter_square = float.Parse(Console.ReadLine());
                plus_of_parallel = parallel1 + parallel2;
                ans = 0.5 * diagonal_line * perimeter_square;
                Console.WriteLine("The area of the Trapizod is: " + ans);
            }

            else
            {
                Console.WriteLine("Unknown shape");
            }
        }
    }
}
