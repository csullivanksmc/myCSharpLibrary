using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Player
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public Player(string make, string model)
        {
            this.Make = make;
            this.Model = model;

        }
    }
}
