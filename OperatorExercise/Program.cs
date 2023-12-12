namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int sum = a + b;
            int dif = a - b;
            int mul = a * b;           

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
            Console.WriteLine();

            Console.WriteLine("Enter any number to be the radius of a circle and I'll output its area.");          
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

            AreaOfCircle(radius);


        }

        public static double AreaOfCircle(double radius)
        {
            return  Math.PI * Math.Pow(radius, 2);            
            
        }
    }
}
