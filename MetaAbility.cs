using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart1
{
    public class MetaAbility
    {
        public Ability Ability { get; set; }

        public MetaAbility() { }

        public MetaAbility(Ability ability)
        {
            Ability = ability;
        }

        public override string ToString()
        {
            return Ability.Name;
        }
    }
}
