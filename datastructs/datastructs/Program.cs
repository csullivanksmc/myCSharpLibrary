using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datastructs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> names = new List<string>
            {
                "names", "ang", "Katara", "sokka"
            };
            foreach (var name in names)
            {
                Console.WriteLine(name);

            }
            names.Add("imposter");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
