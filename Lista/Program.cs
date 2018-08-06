using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listadeinteiros = new List<int>();
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            listadeinteiros.Add(a);
            listadeinteiros.Add(b);
            listadeinteiros.Add(c);
            listadeinteiros.Add(d);

            foreach (int i in listadeinteiros)
            {
                Console.Write(i.ToString());
            }

            Console.ReadLine();

        }
    }
}
