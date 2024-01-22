using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_methods
{
    
    class Delegate3
    {
        public delegate void CallBackFunction(string message); 
        public static void performOperation(CallBackFunction function, string data)
        {
            function("Operation performed: " + data); 
        }

        public static void Runner(string data) {
            Console.WriteLine(data);
        }

        public static void Main(string[] args)
        {
            performOperation(Runner, "ABC"); 
        }

      
    }
}
