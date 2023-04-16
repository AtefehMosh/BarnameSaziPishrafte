using System;

namespace Question_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Width");
            int W = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Heigt");
            int L = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Length");
            int H = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The volume is"+Clac(W, L, H));

        }
        private static double Clac(int x,int y,int z)
        {
            double result = x * y * x;
            return result;
        }
    }
}
