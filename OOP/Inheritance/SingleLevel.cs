using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
     class Animal
    {

        public string Name { get; set; }

        public void printDetails()
        {
            Console.WriteLine($"{Name} sound");
        }
    }


    class Dog : Animal
    {
        public void printDetails()
        {
            Console.WriteLine($"{Name} barking");
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.Name = "Edgar"; 
            dog.printDetails();
        }
    }

   
}
