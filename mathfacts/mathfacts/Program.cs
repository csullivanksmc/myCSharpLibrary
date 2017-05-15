using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathfacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Math Facts app";
            int choice = 0;
            do
            {
                MainAppTitle();
                choice = MainMenu();
            } while (choice != 3);
        }

        private static int MainMenu()
        {
            int choice;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Choose");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Option 1: add");
            Console.WriteLine("Option 2: multiply");
            Console.WriteLine("Option 3: quit");
            choice = Int32.Parse(Console.ReadLine());
            Console.ReadLine();
            return choice;
        }


        private static void MainAppTitle()
        {
            Console.Clear();
            string AppTitle = @"
_________                         __         .__       _____          __  .__     
\_   ___ \_______ ___.__. _______/  |______  |  |     /     \ _____ _/  |_|  |__  
/    \  \/\_  __ <   |  |/  ___/\   __\__  \ |  |    /  \ /  \\__  \\   __\  |  \ 
\     \____|  | \/\___  |\___ \  |  |  / __ \|  |__ /    Y    \/ __ \|  | |   Y  \
 \______  /|__|   / ____/____  > |__| (____  /____/ \____|__  (____  /__| |___|  /
        \/        \/         \/            \/               \/     \/          \/ 
";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(AppTitle);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
