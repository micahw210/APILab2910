using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart1
{
    internal class Type
    {
        public TypesPoke type { get; set; }

        public Type() { }

        public Type(TypesPoke types)
        {
            type = types;
        }

        public override string ToString()
        {
            if (type.Name == "electric")
            {
                Console.ForegroundColor = ConsoleColor.Yellow; 
            }
            else if (type.Name == "water")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (type.Name == "psychic")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            else if (type.Name == "ghost")
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            }
            else if (type.Name == "dark")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (type.Name == "grass")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (type.Name == "bug")
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else if (type.Name == "fighting")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            else if (type.Name == "normal")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (type.Name == "fire")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }


            return type.Name;
            
        }
    }
}
