using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MovieCategories
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                Movie starWars = new Movie("Star Wars", "SciFi");
                Movie empireStrikesBack = new Movie("Empire Strikes Back", "SciFi");
                Movie returnOfTheJedi = new Movie("Return of the Jedi", "SciFi");
                Movie avengersEndGame = new Movie("Avengers End Game", "Family");
                Movie spiderManIntoTheSpiderVerse = new Movie("Spider Man Into The Spiderverse", "Family");
                Movie howToTrainYourDragon = new Movie("How to Train Your Dragon", "Family");
                Movie dieHard = new Movie("Die Hard", "Action");
                Movie commando = new Movie("Commando", "Action");
                Movie rambo = new Movie("Rambo", "Action");
                Movie blairWitchProject = new Movie("Blair Witch Project", "Horror");
                Movie paranormalActivity = new Movie("Paranormal", "Horror");
                Movie nightmareOnElmStreet = new Movie("Nightmare on Elm Street", "Horror");
                Movie pineAppleExpress = new Movie("Pineapple Express", "Comedy");
                Movie anchorMan = new Movie("Anchorman", "Comedy");
                Movie happyGilmore = new Movie("Happy Gilmore", "Comedy");

                List<Movie> SciFi = new List<Movie> { starWars, empireStrikesBack, returnOfTheJedi };
                List<Movie> Family = new List<Movie> { avengersEndGame, spiderManIntoTheSpiderVerse, howToTrainYourDragon };
                List<Movie> Action = new List<Movie> { dieHard, commando, rambo };
                List<Movie> Horror = new List<Movie> { blairWitchProject, paranormalActivity, nightmareOnElmStreet };
                List<Movie> Comedy = new List<Movie> { pineAppleExpress, anchorMan, happyGilmore };


                Console.WriteLine("Welcome to the Movie List Program!");
                Console.WriteLine("There are 10 movies in the list.  Would you like to select from the movie category list? Enter y to continue");
                string response = Console.ReadLine().ToLower();

                if (response == "y")
                {
                    Console.WriteLine("Which category are you interested in?  \nPress 1 for SciFi\nPress 2 for Family\nPress 3 for Action" +
                        "\nPress 4 for Horror\nPress 5 for Comedy\nPress Any Other Key twice to Exit");
                    //Console.WriteLine("Which category are you interested in?  \nEnter:  \nscifi \nfamily \naction \nhorror \ncomedy");
                    //bonus, use numbers to select categories
                    // add .ToLower back to Console Read Line below to list by category type
                    switch (Console.ReadLine())
                    {
                           //scifi
                        case "1":
                            foreach (Movie movie in SciFi)
                            {
                                Console.WriteLine($"{ movie.Title}");
                            };
                            break;
                            //family
                        case "2":
                            foreach (Movie movie in Family)
                            {
                                Console.WriteLine($"{ movie.Title}");
                            };
                            break;
                            //action
                        case "3":
                            foreach (Movie movie in Action)
                            {
                                Console.WriteLine($"{ movie.Title}");
                            };
                            break;
                            //horror
                        case "4":
                            foreach (Movie movie in Horror)
                            {
                                Console.WriteLine($"{ movie.Title}");
                            };
                            break;
                            //comedy
                        case "5":
                            foreach (Movie movie in Comedy)
                            {
                                Console.WriteLine($"{ movie.Title}");
                            };
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
