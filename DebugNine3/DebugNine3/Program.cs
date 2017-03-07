// Creates a Car class
// You can construct a Car using a price and color
// or just a price, in which case a Car is black
// or no parameters, in which case a Car is $10,000 and black
using static System.Console;

namespace DebugNine3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            //needs to set theirCar to new Car()
            Car theirCar = new Car();
            //uses myCar not myCarr
            //color should be in Pascal Casing
            WriteLine("My {0} car cost {1}", myCar.Color,
               myCar.Price.ToString("c2"));
            //there is no youRCar its yourCar
            //Price is in Pascal Casing same with ToString
            WriteLine("Your {0} car cost {1}",
               yourCar.Color, yourCar.Price.ToString("c2"));

            //Price is in Pascal Casing
            WriteLine("Their {0} car cost {1}",
               theirCar.Color, theirCar.Price.ToString("c2"));
        }
    }
    class Car
    {
        private string color;
        private int price;
        public Car() : this(10000, "black")
        {
        }
        public Car(int price) : this(price,"")
        {
        }
        public Car(int price, string color)
        {
            //this should be price
            Price = price;
            Color = color;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Price
        {
            get
            {
                //return price
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
