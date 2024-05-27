using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
    }

    class Bus
    {
        public int? Load;

        public void PrintStatus()
        {
            if (Load.HasValue && Load > 0)
            {
                Console.WriteLine("В авбтобусе {0} пассажиров", Load.Value);
            }
            else
            {
                Console.WriteLine("Автобус пуст!");
            }
        }
    }
}
