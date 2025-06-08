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
            ContinueCheck();
        }

        public static void TriangleAreaCalculation()
        {
            Console.WriteLine("Area of a triangle = base multiplied by height, divided by 2.");
            Console.WriteLine("Enter Base");
            double baseLength = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            double Height = double.Parse(Console.ReadLine());
            Console.WriteLine($"Triangle Area = {baseLength * Height / 2}");
            ContinueCheck();
        }

        public static void RectangleAreaCalculation()
        {
            Console.WriteLine("Area of a rectangle = length multiplied by width.");
            Console.WriteLine("Enter Length");
            double Length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width");
            double Width = double.Parse(Console.ReadLine());
            Console.WriteLine($"Rectangle Area = {Length * Width}");
            ContinueCheck();
        }

        public static void SquareAreaCalculation()
        {
            Console.WriteLine("Area of a square = the square of the side length.");
            Console.WriteLine("Enter side length");
            double sideLength = double.Parse(Console.ReadLine());
            Console.WriteLine($"Square Area = {sideLength * sideLength}");
            ContinueCheck();
        }
        
        public static void SelectShape()
        {
            Console.WriteLine("Please tell me your shape: Circle, Triangle, Rectangle, Square.");
            string shape = Console.ReadLine().Trim().ToLower();

            switch (shape)
            {
                case "circle":
                    CircleAreaCalculation();
                    break;
                case "triangle":
                    TriangleAreaCalculation();
                    break;
                case "rectangle":
                    RectangleAreaCalculation();
                    break;
                case "square":
                    SquareAreaCalculation();
                    break;
                default:
                    Console.WriteLine("Invalid shape entered. Please try again.");
                    SelectShape();
                    break;
            }
        }

        public static void ContinueCheck()
        {
            Console.WriteLine("Do you have more shapes to calculate?"); 
            string YesNo = Console.ReadLine().Trim().ToLower();
            switch (YesNo)
            {
                case "yes":
                    SelectShape();
                    break;
                case "no":
                    Console.WriteLine("Thank you for using the Shape Area Calculator by Matthew D. Yglesias.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    ContinueCheck();
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Activated");
            Console.WriteLine("Welcome to the Shape Area Calculator by Matthew D. Yglesias.");
            SelectShape();
            Console.WriteLine("Calculator Deactivated. Have a nice day.");
        }
    }
}
