namespace PokemonKlasserOsv
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*PlayerPokemon bulbasaur = new PlayerPokemon();
            PlayerPokemon squirtle = new PlayerPokemon();
            PlayerPokemon charmander = new PlayerPokemon();
            WildPokemon pidgey = new WildPokemon();
            WildPokemon rattata = new WildPokemon();
            WildPokemon caterpie = new WildPokemon();
            WildPokemon spearow = new WildPokemon();*/

            var logics = new Logics();
            var gameplay = new Logics();

            bool keepPlaying = true;

            string inputVal = "";
            while (inputVal != "3")
            {
                Menu(); // börjar med att ge spelaren olika val - > switch 
              
                inputVal = (Console.ReadLine());

                switch (inputVal)
                {
                    case "1": //how to play

                        Instructions();
                        break;

                    case "2": 
                        logics.ChoosePokemon();
                        break;

                    case "3": // quit game
                        Console.WriteLine("Thank you for playing!");
                        break;

                    default://wrong input value
                        Console.WriteLine("Wrong input value.");
                        break;
                }
              
                logics.Spelomgång();

                inputVal = (Console.ReadLine());
                switch (inputVal)
                {
                    case "1":
                        logics.TallGrass();
                        Console.WriteLine("TallGrass");
                        break;
                    case "2":
                        logics.Details();
                        Console.WriteLine("Details");

                        break;
                    case "3":
                        Console.WriteLine("Thank you for playing");
                        break;

                        break;
                    default:
                        Console.WriteLine("Wrong input value.");
                        break;
                }
                                           
            }
        }
        static void Menu() 
        {
            Console.WriteLine("Chose one of the following: ");
            Console.WriteLine("1. How to play!");
            Console.WriteLine("2. Pokemon");
            Console.WriteLine("3. Quit the game (only for cowards)");
        }
                    
        static void Instructions() 
        {
            Console.Clear();
            Console.WriteLine("instructions");
            
        }            
 
      
    }

}
