using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PokemonKlasserOsv
{
    public class PlayerPokemon

    {
        public PlayerPokemon()
        {        
      
        }
        public string? Name { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Exp { get; set; }
        public int Level { get; set;}
    }


    public class Bulbasaur : PlayerPokemon
    {
        
        public Bulbasaur()
        {
           
            Name = "Bulbasaur";
            HP = 45;
            Attack = 49;
            Level = 1;

        }
        public void attack()
        {
            Random random = new Random();
            Attack = random.Next(1,49);
            Console.WriteLine($"Bulbasaur attacked and caused {Attack} damage");
        }
    }

    public class Squirtle : PlayerPokemon
    {
        public Squirtle()
        {
            Name = "Squirtle";
            HP = 44;
            Attack = 48;
            Level= 1;

        }
    }

    public class Charmander : PlayerPokemon
    {
        public Charmander()
        {
            Name = "Charmander";
            HP = 39;
            Attack = 52;
            Level = 1;


        }
    }
}
  


