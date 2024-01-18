using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Inheritance
{
    class SeniorVicePresident 
    {
        public void printDetails()
        {
            Console.WriteLine("Senior vice president");
        }
    }

    class VP:  SeniorVicePresident { 
        public void printDetails()
        {
            Console.WriteLine("Vice President");
        }
    }

    class AVP :  SeniorVicePresident
    {

        public void printDetails()
        {
            Console.WriteLine("AVP"); 
        }
    }
}
