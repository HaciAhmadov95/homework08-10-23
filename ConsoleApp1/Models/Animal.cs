using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Animal
    {
        public int id { get; set; }
        public virtual void Sound()
        {
            Console.WriteLine("Animal Sound");

        }
    }
}