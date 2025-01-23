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
                    int pokemon = random.Next(4);
                    switch(pokemon)
                    {
                        case 0:
                            {
                                Console.WriteLine("Choose");
                                break;
                            }
                        case 1:
                            {
                                Console.WriteLine("#1 Bulbasaur");
                                break;
                            }
                        case 2:
                            {
                                Console.Write("#38 Ninetales ");
                                Random t = new Random();
                                int type = t.Next(2);
                                if (type == 0)
                                {
                                    Console.WriteLine("Normal");
                                }
                                else if (type == 1)
                                {
                                    Console.WriteLine("Alolan");
                                }
                                break;
                               
                            }
                        case 3:
                            {
                                Console.WriteLine("#4 Charmander");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Non existent (error 404)");
                                break;
                            }
                    }
                    fisk++;
                    Thread.Sleep(1800);
                    
                }
                Console.WriteLine("Team End");
                Console.WriteLine(" ");
                i++;
            }
            while (i < teams);
        }
    }
}