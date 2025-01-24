using System;
namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Random Pokémon Generator!");
            Console.WriteLine("How many teams of six(6) do you want to generate?");
            int teams = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine("Team Start:");
                int fisk = 0;
                while(fisk < 6)
                {
                    Random random = new Random();
                    int pokemon = random.Next(14);
                    switch(pokemon)
                    {
                        case 0:
                            {
                                Console.WriteLine("#???? MissingNo. (Choose a Pokémon Freely!)");
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("#1 Bulbasaur ");
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("#2 Ivysaur ");
                                break;
                               
                            }
                        case 3:
                            {
                                Console.WriteLine("#3 Venusaur ");
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("#4 Charmander ");
                                break;
                            }
                        case 5:
                            {
                                Console.WriteLine("#5 Charmeleon ");
                                break;
                            }
                        case 6:
                            {
                                Console.WriteLine("#6 Charizard ");
                                break;
                            }
                        case 7:
                            {
                                Console.WriteLine("#7 Squirtle ");
                                break;
                            }
                        case 8:
                            {
                                Console.WriteLine("#8 Wartortle ");
                                break;
                            }
                        case 9:
                            {
                                Console.WriteLine("#9 Blastoise ");
                                break;
                            }
                        case 10:
                            {
                                Console.WriteLine("#10 Caterpie ");
                                break;
                            }
                        case 11:
                            {
                                Console.WriteLine("#11 Metapod ");
                                break;
                            }
                        case 12:
                            {
                                Console.WriteLine("#12 Butterfree ");
                                break;
                            }
                        case 13:
                            {
                                Console.WriteLine("#13 Weedle ");
                                break;
                            }
                        case 14:
                            {
                                Console.WriteLine("#14 Kakuna ");
                                break;
                            }
                        case 15:
                            {
                                Console.WriteLine("#15 Beedrill ");
                                break;
                            }
                        case 16:
                            {
                                Console.WriteLine("#16 Pidgey ");
                                break;
                            }
                        case 17:
                            {
                                Console.WriteLine("#17 Pidgeotto ");
                                break;
                            }
                        case 18:
                            {
                                Console.WriteLine("#18 Pidgeot ");
                                break;
                            }
                        case 19:
                            {
                                Console.WriteLine("#19 Rattata ");
                                break;
                            }
                        case 20:
                            {
                                Console.WriteLine("#20 Raticate ");
                                break;
                            }
                    }
                    fisk++;
                    Thread.Sleep(10);
                    
                }
                Console.WriteLine("Team End");
                Console.WriteLine(" ");
                i++;
            }
            while (i < teams);
        }
    }
}