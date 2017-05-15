using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CarMaker
{

    class prompt
    {
        static void Main(string[] args)
        {
            Car usersCar = new Car();

            Console.WriteLine("What kind of car do you drive?");
            usersCar.make = Console.ReadLine();

            Console.WriteLine("And what color is your " + usersCar.make + "?");
            usersCar.color = Console.ReadLine();

            Console.WriteLine("you drive a " + usersCar.color + usersCar.make);
            Console.ReadLine();

            if (usersCar.make == "ferrari")
            {
                Console.WriteLine("keep dreamin BOYO.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ok so you drive a ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(usersCar.make);
                Console.ReadLine();
            }
        }
    }
}
