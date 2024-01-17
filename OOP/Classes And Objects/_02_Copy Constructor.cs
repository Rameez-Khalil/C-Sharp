using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{
    class Student
    {
        public int id; 
        public string name;

        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
        }


        //COPY CONSTRUCTOR - This will fetch the details of a provided object.
        public Student(Student s)
        {
            this.id = s.id;
            this.name = s.name;
        }

        public void printDetails()
        {
            Console.WriteLine("{0} {1}", name, id);
        }


        
    }


   
}
