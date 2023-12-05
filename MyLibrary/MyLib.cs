namespace MyLibrary
{
    public class MyLib
    {
        public void Add(double x, double y)
        {
            Console.WriteLine(x + y);
        }
        public void Subtract (double x, double y)
        {
            Console.WriteLine(x - y);
        }
        public void Multiply (double x, double y)
        {
            Console.WriteLine(x * y);
        }
        public void Divide (double x, double y)
        { 
            Console.WriteLine(x / y);
        }

        public void Pow(double x, double y)
        {
            double result = 1;
            for (double i = 0; i < y; i++)
            {
                result *= x;
            }
            Console.WriteLine(result);
        }

        public void Sqrt(double x)
        {
            double res = 1;
            res /= x;
            Console.WriteLine(res);
        }
    }
}