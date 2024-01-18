using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {

        public void printDetails()
        {
            Console.WriteLine("Employee main class");
        }
    }

    class QC : Employee
    {
        public void printDetails()
        {
            Console.WriteLine("QC class");
        }
    }

    class OP : QC
    {
        public void printDetails()
        {
            Console.WriteLine("OP class");
        }
    }


    

}
