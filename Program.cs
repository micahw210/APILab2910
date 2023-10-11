using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace APIPart1
{
    class Program
    {
        static async Task Main()
        {
            List<string> list = new List<string>();
            string input;
            bool yon = true;

            do
            {
                Menu();

                Console.WriteLine("Choose and option");
                int option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("How many pokemon would you like to see?");
                        int num = int.Parse(Console.ReadLine());

                        for (int i = 0; i < num; i++)
                        {
                            Console.WriteLine("Choose a pokemon");
                            input = Console.ReadLine().ToLower();

                            list.Add(input);
                        }

                        Console.WriteLine("Click to continue");
                        Console.ReadLine();
                        Console.Clear();

                        break;

                    case 2:
                        Console.WriteLine("------LIST OF SELECTED POKEMON------");


                        foreach (string i in list)
                        {
                            await MonsterCall(i);
                            Console.ResetColor();
                        }

                        Console.WriteLine("Click to continue");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        yon = false;
                            break;

                }
            } while (yon != false);


        }

        static void Menu()
        {
            Console.WriteLine("[1] Choose your Pokemon");
            Console.WriteLine("[2] Selected Pokemon");
            Console.WriteLine("[3] Exit");
        }

        public static async Task MonsterCall(string input)
        {
            // sending our request to https://pokeapi.co/api/v2/pokemon/{index}

            // json for all of these monsters
            var monsterNames = new string[] {input};

            // create a HttpClient object to use to send the request
            var client = new HttpClient();

            foreach (var monsterName in monsterNames)
            {
                
                HttpResponseMessage response = await client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{monsterName}");

                
                string json = await response.Content.ReadAsStringAsync();

                var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                Pokemon monster = JsonSerializer.Deserialize<Pokemon>(json, options);
                Console.WriteLine(monster + "\n");
            }
        }
    }
}
