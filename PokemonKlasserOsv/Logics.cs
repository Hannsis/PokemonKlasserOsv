using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonKlasserOsv
{
    public class Logics
    {

        public PlayerPokemon ChoosePokemon()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the world of pokémon! ");
            Console.WriteLine("There are wild pokemon in the wild grass, it's dangerous to go alone! \n");
            Console.WriteLine
                   ($"Time to pick your pokemon! Which pokemon do you chose? " +

                   $"\n\n1. Bulbasaur has 44 HP, is a grass type pokémon, its attacks are: " +
                   $"\ntackle \nleech seed \nvine whip \nand growl!" +
                   $"\n\n2. Charmander has 44 HP, is a fire type pokémon, its attacks are: " +
                   $"\ngrowl \nscratch \nember \nand leer!" +
                   $"\n\n3. Squirtle is a water type pokémon, it has 44 HP! And it's attacks are: " +
                   $"\nTackle, \nwatergun, \ntailwhip \nand bubble!");

            string pokemonChoice = Console.ReadLine();

            switch (pokemonChoice)
            {
                case "1":
                    {
                        Console.Clear();
                        Bulbasaur bulbasaur = new Bulbasaur();
                        Console.WriteLine($"You have chosen {bulbasaur.Name}");
                        return bulbasaur;                  
                    }
                case "2":
                    {
                        Console.Clear();
                        Charmander charmander = new Charmander();
                        Console.WriteLine($"You have chosen {charmander.Name}");
                        return charmander;
                    }
                case "3":
                    {
                        Console.Clear();
                        Squirtle squirtle = new Squirtle();
                        Console.WriteLine($"You have chosen {squirtle.Name}");                     
                        return squirtle;
                    }
                default:
                    PlayerPokemon playerPokemon = new PlayerPokemon();
                    return playerPokemon;
                    
            }
            
        }

        public void Spelomgång()
        {
            Console.WriteLine("1. The tall grass has wild pokemon in it! Do you want to go there?");
            Console.WriteLine("2. Show details about pokemon.");
            Console.WriteLine("3. Quit game.");

        }

        public void TallGrass() 
        {
        //10% chans nothing happens
        //10% chans meets a trainer
        //a wild pokemon appears
        }

        public void Details() 
        {
        
        }

        enum Pokemon
        { 
                Bulbasaur,
                Squirtle,
                Charmander
        }

        enum BulbasaursAttacks
        {
            Growl,
            Tackle,
            Vine_Whip,
            Leech_Seed
        }

        enum CharmandersAttacks
        {
            Growl,
            Scratch,
            Leer,
            Ember

        }

        enum SquirtlesAttacks
        {
            Tackle,
            Bubble,
            Watergun,
            Tail_Whip
        }

    }
}
