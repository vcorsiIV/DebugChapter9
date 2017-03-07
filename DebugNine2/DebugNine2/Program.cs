// Creates a Breakfast class
// and instantiates an object
// Displays Breakfast special information
using static System.Console;

namespace DebugNine2
{
    class Program
    {
        static void Main(string[] args)
        {
            //close the quotes.
            Breakfast special = new Breakfast("French toast", 4.99);
            //Display the info about breakfast
            //change to special.INFO to read the public string
            WriteLine(special.INFO);
            // then display today's special
            //special.Name
            WriteLine("Today we are having {0} for {1}",
               special.Name, special.Price.ToString("C2"));
        }
    }
    class Breakfast
    {
        public string INFO =
           "Breakfast is the most important meal of the day.";
        private string name;
        //make private double Price with price in camel casing
        private double price;
        // Breakfast constructor requires a
        // name, e.g "French toast", and a price
        public Breakfast(string name, double price)
        {
            //Set the methods to equal the value that are being input
            Name = name;
            Price = price;
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
        public double Price {
            get { return price; }
            set { price = value; }
        }
    }
}
