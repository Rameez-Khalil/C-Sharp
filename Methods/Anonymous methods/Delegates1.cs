using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_methods
{
    class Delegates1
    {
        public delegate void PetAnimal(string s1);
        public static PetAnimal petAnimal = delegate (string s)
        {
            Console.WriteLine("Animal: " + s);
        }; 

       
    }


}
