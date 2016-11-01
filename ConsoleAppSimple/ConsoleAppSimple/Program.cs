using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppSimple.Models;

namespace ConsoleAppSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is simple console app"); 
            Person p = new Person(45);
            p.FirstName = "Han";
            p.LastName = "Solo";

            Console.WriteLine(p);
        }
    }

}
