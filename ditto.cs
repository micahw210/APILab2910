using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPart1
{
    internal class Pokemon
    {
        // all i want from API is the name & a list of the ability names
        public string Name { get; set; } = string.Empty;
        public List<MetaAbility> Abilities { get; set; } = new List<MetaAbility>();
        public List<Type> Types { get; set; } = new List<Type>();
        public Pokemon() { }
        public Pokemon(string name, List<MetaAbility> abilities, List<Type> types)
        {
            Name = name;
            Abilities = abilities;
            Types = types;
        }

        public override string ToString()
        {
            string pokemonString = "";
            pokemonString += $"Name: {Name}\n";
            pokemonString += $"Abilities: {String.Join(',', Abilities)}\n";
            pokemonString += $"Types: {String.Join(',', Types)}";

            return pokemonString;
        }
    }
}
