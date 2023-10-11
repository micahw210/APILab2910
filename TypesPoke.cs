using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart1
{
    public class TypesPoke
    {
        public string Name { get; set; } = string.Empty;

        public TypesPoke() { }

        public TypesPoke(string name)
        {
            Name = name;
        }
    }
}
