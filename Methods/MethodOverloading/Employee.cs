using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Employee
    {
        public String name;
        public int id;
        public int age;

        public Employee(string name, int id, int age)
        {
            this.name = name;
            this.id = id;
            this.age = age;
        }

        public void show()
        {
            Console.WriteLine("Name: " + this.name + "ID: " + this.id);
        }

        public void show(int id)
        {
            Console.WriteLine("Name: " + this.name + "ID: " + this.id + "Age: " + this.age);
        }

        
    }


    class Program
    {
        public static void Main(string[] args)
        {
            Employee emp = new Employee("Rameez", 1001, 25);

            emp.show(emp.id);
        }
    }
}
