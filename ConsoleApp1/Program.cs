using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000; i++)
            {
                bool done = true;
                for (int j = 2; j < i-1; j++)
                {
                    if (i%j == 0)
                    {
                        done = false;
                    }
                }
                if (done)
                {
                    Console.Write(i.ToString() + " ");
                }
            }
            while (true){}
        }
    }
}
