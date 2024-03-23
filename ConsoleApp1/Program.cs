using System;
using static System.Math;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Square(int osn, int nn)
            {
                double st = 1;
                for (int i = 1; i <= nn; i++)
                {
                    st = st * osn;
                }
                return st;
            }

            double Sum(double[] mas)
            {
                double sum = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    sum += mas[i];
                }
                return sum;
            }

            Console.Write("Введите кол-во элементов массива(k): ");
            int k = int.Parse(Console.ReadLine());
            double[] x = new double[k];
            for(int i = 0; i < k; i++)
            {
                x[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Введите кол-во элементов массива(t): ");
            int t = int.Parse(Console.ReadLine());
            double[] y = new double[t];
            for (int i = 0; i < t; i++)
            {
                y[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            double answer = Sqrt(Square(a, k) + Square(b, t)) / (Sum(x) - b) + Sum(y);
            Console.WriteLine($"Ответ: {answer}");
        }
    }
}
