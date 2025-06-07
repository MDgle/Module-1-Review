using System;
namespace MethodsExercise
{
    public class Program
    {

        public static void CircleAreaCalculation()
        {
            Console.WriteLine("Area of a circle = PI multiplied by the square of the radius.");
            Console.WriteLine("Enter Radius");
            double Radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Circle Area = {Math.PI * (Radius*Radius)}");
        }

        public static void TriangleAreaCalculation()
        {
            Console.WriteLine("Area of a triangle = base multiplied by height, divided by 2.");
            Console.WriteLine("Enter Base");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            double Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Triangle Area = {baseLength * Height / 2}");
        }

        public static void RectangleAreaCalculation()
        {
            Console.WriteLine("Area of a rectangle = length multiplied by width.");
            Console.WriteLine("Enter Length");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            double Width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Rectangle Area = {Length * Width}");
        }

        public static void SquareAreaCalculation()
        {
            Console.WriteLine("Area of a square = the square of the side length.");
            Console.WriteLine("Enter side length");
            double sideLength = double.Parse(Console.ReadLine());
            Console.WriteLine($"Square Area = {sideLength * sideLength}");
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Calculator Activated");
            CircleAreaCalculation();
            TriangleAreaCalculation();
            RectangleAreaCalculation();
            SquareAreaCalculation();
           Console.WriteLine("Calculator Deactivated. Have a nice day.");
        }
    }
}
