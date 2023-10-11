using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart1
{
    public class Ability
    {
        public string Name { get; set; } = string.Empty;

        public Ability() { }

        public Ability(string name)
        {
            Name = name;
        }
    }
}
