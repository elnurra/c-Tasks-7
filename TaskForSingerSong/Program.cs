using System;
using TaskForSingerSong.Models;

namespace TaskForSingerSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input name of singer: ");
            string nameofSinger = Console.ReadLine();
            Console.WriteLine("Input surname of singer: ");
            string surnameofSinger = Console.ReadLine();
            Console.WriteLine("Input age of singer: ");
            int ageofSinger = Convert.ToInt32(Console.ReadLine());

            Singer anysinger = new Singer
            {
                Name = nameofSinger,
                Surname = surnameofSinger,
                Age = ageofSinger
            };

            Console.Write("Input Singer's name song:");
            string nameofSong = Console.ReadLine();
            Console.Write("Input Singer's genre song:");
            string genreofSong = Console.ReadLine();

            Song anysong = new Song
            {
                Name = nameofSong,
                Genre = genreofSong,
                Singer = anysinger
            };

            int input;
            do
            {
                Console.WriteLine("Choose 1 of them: \n (1) - Rate song: \n (0) - Exit");
                input = Convert.ToInt16(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Rate songs from 0 to 10: ");
                    int rate = int.Parse(Console.ReadLine());
                    if (rate >= 0 && rate <= 10)
                    {
                        anysong.AddRating(rate);
                        Console.WriteLine("Do u want add rating for current song? \n (0) - Rate song: \n (1) - Exit  ");
                        input = Convert.ToInt16(Console.ReadLine());
                        if (input == 0)
                        {
                            if (rate >= 0 && rate <= 10)
                            {
                                anysong.AddRating(rate);
                            }
                        }
                        
                        
                        
                    }
                    else
                    {
                        Console.WriteLine("Your input is wrong: ");
                    }
                    


                }
                else
                {

                    break;
                }
                

            } while (input == 0);
            anysong.GetInfo();
        }
    }
}
