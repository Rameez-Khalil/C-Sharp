using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Objects
{

    /*
     * Points To Remember :  
            It is the implementation of a singleton class pattern.
            use private constructor when we have only static members.
            Using private constructor, prevents the creation of the instances of that class.
     */

    class CoffeeMachine
    {
        public static int count= 0;
        public string brandName; 

        private CoffeeMachine(string s) { 
           count++;
           this.brandName= s; 
        }

        public static CoffeeMachine generateCoffeeMachine(string s)
        {
            if (count == 0)
            {
                CoffeeMachine machine = new CoffeeMachine(s);
                Console.WriteLine("Coffee Machine: " + s);
                return machine;
            }
            return null; 
        }

       

    }
}
