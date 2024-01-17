using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    class Animal
    {
        public string name; 
        public int age; 
        public int id;


        //This is an example of a parameterized constructor
        public Animal(string name, int age, int id)
        {
            this.name = name;
            this.age = age;
            this.id = id;
        }

        public void printDetails()
        {
            Console.WriteLine("{0}, {1}", name, age);
        }

    }

}
