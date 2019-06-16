using System;

namespace FunPlacesToGo
{
    class Program
    {
        static string selectedActivityOption;
        static int numberOfPeople;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input your name:");
            var name = Console.ReadLine();
            name = !string.IsNullOrWhiteSpace(name) ? name : "user";
            Console.WriteLine($"Hello {name}, what are you in the mood for?");
            Console.WriteLine("Here are your options");
            PresentActivityOptions();
            DisplayResult();
            Console.ReadKey();
        }

        static void PresentActivityOptions()
        {
            Console.WriteLine("1) Action");
            Console.WriteLine("2) Chill times");
            Console.WriteLine("3) Danger");
            Console.WriteLine("4) Good food");
            selectedActivityOption = Console.ReadLine();

            // Ensure the user selects an option
            if (string.IsNullOrWhiteSpace(selectedActivityOption))
            {
                PresentActivityOptions();
            }
            PresentTravelOptions();
        }

        static void PresentTravelOptions()
        {
            Console.WriteLine("How many people are you bringing with you? (Number)");
            var answer = Console.ReadLine();

            // If user didn't set a value, set numberOfPeople to 0
            if (string.IsNullOrWhiteSpace(answer))
            {
                numberOfPeople = 0;
            }
            else
            {
                numberOfPeople = int.Parse(answer);
            }
        }

        static void DisplayResult()
        {
            string option = null;
            string activity = null;
            string travelMeans = null;
            string error = null;

            if (selectedActivityOption == "1")
            {
                option = "action";
                activity = "Stock Car Racing";
            }
            else if (selectedActivityOption == "2")
            {
                option = "chilling";
                activity = "Hiking";
            }
            else if (selectedActivityOption == "3")
            {
                option = "danger";
                activity = "Skydiving";
            }
            else if (selectedActivityOption == "4")
            {
                option = "good food";
                activity = "to Taco Bell";
            }
            else
            {
                error = "Sorry we didn't understand your input";
            }

            if (numberOfPeople <= 0)
            {
                travelMeans = "sneakers!";
            }
            else if (numberOfPeople <= 4)
            {
                travelMeans = "a sedan!";
            }
            else if (numberOfPeople <= 10)
            {
                travelMeans = "a Volkswagen bus!";
            }
            else if (numberOfPeople > 10)
            {
                travelMeans = "an airplane!";
            }

            DisplayResult(activity, option, travelMeans, error);
        }

        static void DisplayResult(string activity, string option, string travelMeans, string error)
        {
            Console.WriteLine();
            if (!string.IsNullOrWhiteSpace(error))
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine($"Okay if you’re in the mood for {option}, then you should go {activity} and travel in {travelMeans}");
            }

            Console.WriteLine("Goodbye");
        }
    }
}
