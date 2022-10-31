// Adlari elifba sirasi ile duzmek


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Names = new List<string>();

            Names.Add("Vaqif");
            Names.Add("Zamiq");
            Names.Add("Akif");
            Names.Add("Kerim");
            Names.Add("Qurban");
            Names.Sort();
            Console.WriteLine("Names in Alphabetical Order");
            foreach (string n in Names)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();
        }
       
    }
}