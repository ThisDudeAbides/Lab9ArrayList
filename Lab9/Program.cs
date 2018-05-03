using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    { //static int StudentCount = 0;
        static void Main(string[] args)

        {
            // set up database
            // ask about index
            //ask about hometown and favorite food with if/else if/ else
            //>> else is the validation for incorrect input
            // print user info

            List<string> Names = new List<string> { "Amy","Kim","Tyler","Rachel","Andy","Sarah","John",
                "Kevin", "Ken", "Matthew"};
            List<string> FavoriteFoods = new List<string> { "pizza","grapes","fries","mashed ptatos","green beens",
                "fried chicken","ribs","candy","hot pocket", "chicken nuggets","cheese"};
            List<string> HomeTown = new List<string> { "Detroit", "Ann Arbor", "Saline", "Boston", "Chicago", "NewYork", "phoenix", "orlando", "seattle", "dallas" };
            List<string> FavoriteColor = new List<string> { "pink", "green", "red", "blue", "orange", "blue", "red", "green", "blue", "yellow" };

            int NameId;

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("would you like to learn about a specific student or would you  like to add cool facts about a new student: " +
                    "enter(add) for new student or (more) to learn more about a current student ");
                string response = Console.ReadLine().ToLower();

                if (response == "more")
                {
                    Console.WriteLine($"what student would you like to learn about? please select a number between (1-{Names.Count})");
                    NameId = int.Parse(Console.ReadLine()) - 1;
                    Console.WriteLine($"{Names[NameId]}");


                    Console.WriteLine($"would you like to learn about {Names[NameId]}'s Favorite Food, Hometown or Favorite Color? please pick one: Food/Home/Color");
                    string Pick = Console.ReadLine().ToLower();
                    if (Pick == "food")
                    {
                        Console.WriteLine($"{Names[NameId]}'s Favorite Food is {FavoriteFoods[NameId]}");
                        break;
                    }
                    else if (Pick == "home")
                    {
                        Console.WriteLine($"{Names[NameId]}'s Home Town is {HomeTown[NameId]}");
                        break;
                    }
                    else if (Pick == "color")
                    {
                        Console.WriteLine($"{Names[NameId]}'s Favorite Color is {FavoriteColor[NameId]}");
                        break;
                    }

                    Console.WriteLine("would you like to learn about a different student: y/n");
                    string MoreInfo = Console.ReadLine().ToLower();
                    if (MoreInfo == "n")
                    {
                        repeat = false;
                    }
                }
                else if (response == "add")
                {
                    
                        Console.WriteLine(" what is the name of the student you would like to add?");
                        string AddStudent = Console.ReadLine();
                        while (!Regex.IsMatch(AddStudent, "^[A-Za-z ]{1,}$"))
                        {
                            Console.WriteLine("Invalid name. Try again.");
                            AddStudent = Console.ReadLine();
                        }
                        Names.Add(AddStudent);
                        Console.WriteLine($"what is {AddStudent}'s Favorite food?");
                        string AddFavFood = Console.ReadLine();
                        while (!Regex.IsMatch(AddFavFood, "^[A-Za-z ]{1,}$"))
                        {
                            Console.WriteLine($"invalid input, please enter {AddStudent} favorite food");
                            AddFavFood = Console.ReadLine();
                        }
                        FavoriteFoods.Add(AddFavFood);

                        Console.WriteLine($"what is {AddStudent}'s Hometown?");
                        string AddHomeTown = Console.ReadLine();
                        while (!Regex.IsMatch(AddHomeTown, "^[A-Z][A-Za-z]{1,}$"))
                        {
                            Console.WriteLine("Invalid Hometown. Try again.");
                            AddHomeTown = Console.ReadLine();
                        }
                        HomeTown.Add(AddHomeTown);


                        Console.WriteLine($"what is {AddStudent}favorite color?");
                        string AddFavColor = Console.ReadLine();
                        while (!Regex.IsMatch(AddFavColor, "^[A-Z][A-Za-z]{1,}$"))
                        {
                            Console.WriteLine("Invalid color. Try again.");
                            AddFavColor = Console.ReadLine();
                        }
                        FavoriteColor.Add(AddFavColor);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }

        }

    }
}

