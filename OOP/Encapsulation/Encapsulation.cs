using System; 
namespace OOP
{
    class Encapsulation
    {
        private string name;
        private int id; 

        public string Name { get { return name; } set { name = value; } }
        public int Id { get { return id; } set { id = value; } }


        class Program
        {
            public static void Main(string[] args)
            {
                Encapsulation encapsulation = new Encapsulation();
                encapsulation.Name = "rameez";
                encapsulation.id = 1;

                Console.WriteLine(encapsulation.name);
                Console.WriteLine(encapsulation.id);
            }
        }
    }
}