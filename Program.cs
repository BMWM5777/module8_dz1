using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module8_dz1
{
     class Program
    {
        static void Main(string[] args)
        {
            indexator indexator1 = new indexator(5);
            indexator1[0] = 2;
            indexator1[1] = 3;
            indexator1[2] = 4;
            indexator1[3] = 5;
            indexator1[4] = 6;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"indexator1[{i}] = {indexator1[i]}");
            }
        }
    }
}
