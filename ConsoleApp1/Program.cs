namespace ConsoleApp1
{
    internal class Program
    {
        static double Heron(double a,double b,double c)
        {
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return s;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a, b ,c");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b <=c || a+c<=b ||c+b<=a)
            {
                Console.WriteLine("nie ma takiego trojkata");
            }
            else Console.WriteLine(Heron(a, b, c));


        }
    }
}