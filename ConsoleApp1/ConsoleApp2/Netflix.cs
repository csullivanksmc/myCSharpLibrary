using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Netflix
    {
        string name;
        string genre;
        int rating;
        public string suggestions()
        {
            if (rating > 3)
            {
                return "yea 8/8 would watch.";
            }
            else
            {
                return "dont even bother my guy?";
            }
        }
    }
}
