using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarinaData;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = MarinaManager.GetAvailableSlips();
            foreach (object s in a){
                Console.WriteLine(s);
                Console.ReadLine();
            }
           
        }
    }
}
