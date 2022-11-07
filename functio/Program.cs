using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functio
{
    internal class Program
    {
        static void Main(string[] args)
        {
        string[] first = new string[5] { "Мария", "Анастасия", "Анатолий", "Иван", "Ася" };
            Console.Write(Name(first));
            Console.ReadKey();
        }

        public static int Name(string[] first)
        {
            int n = 0;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i].Length >= 5)
                {
                    n++;
                }
            }
            return n;

        }
    }
}
