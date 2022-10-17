using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonKlasserOsv
{
    internal class WildPokemon
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
     

        public class Rattata : WildPokemon
        {
            public Rattata() 
            {
                Name = "Rattata";
                HP = 0;
                Attack = 0;
            }
        }
        public class Pidgey : WildPokemon
        {
            public Pidgey() 
            {
                Name = "Pidgey";
                HP = 0;
                Attack = 0;
            }
    
        }
        public class Spearow : WildPokemon
        {
            public Spearow()
            {
                Name = "Spearow";
                HP = 0;
                Attack = 0;
            }
        }

        public class Caterpie : WildPokemon
        {
            public Caterpie()
            {
                Name = "Caterpie";
                HP = 0;
                Attack = 0;
            }
        }
    }

}

