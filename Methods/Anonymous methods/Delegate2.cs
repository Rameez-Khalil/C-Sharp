using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_methods
{

    //Accessing outer variables.
     class Delegate2
    {
        public delegate void PetAnimal(string name);
        public static string fav = "rabbit"; 
        public static PetAnimal petAnimal = delegate (string name)
        {
            Console.WriteLine("Favorite Animal: " + name);
            Console.WriteLine("Favorite pet animal: " + fav);
        };

       


    }
}
