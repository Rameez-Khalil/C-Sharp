using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    /*
     * 
        It can’t be called directly.
        When it is executing then the user has no control.
        It does not take access modifiers or any parameters.
        It is called automatically to initialize the class before the first instance created.
     */
    class Employee
    {
        public string name;
        public int age;

        public Employee(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void printDetails()
        {
            Console.WriteLine("{0},{1}",name, age);
        }


        //THIS IS THE STATIC CONSTRUCTOR, THIS WILL BE THE FIRST ONE TO EXECUTE, NO MATTER WHAT. 
        static Employee()
        {
            Console.WriteLine("I AM THE FIRST PERSON TO BE CALLED");
        }

        public static void Main(string[] args)
        {
            Employee employee = new Employee("Zubair", 35);
            employee.printDetails();
        }
    }
}
