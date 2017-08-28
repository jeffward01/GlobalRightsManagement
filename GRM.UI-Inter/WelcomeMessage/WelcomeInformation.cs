using System;
using System.Linq;
using GRM.UI_Inter.About;

namespace GRM.UI_Inter.WelcomeMessage
{
    public class WelcomeInformation
    {

        private readonly IAboutPage _aboutPage;

        public WelcomeInformation(IAboutPage aboutPage)
        {
            aboutPage = _aboutPage;
        }


        public void DisplayIntro()
        {
            CommonMethods.WriteLine("Welcome to Global Rights Management! (GRM)");
            CommonMethods.SpaceLg();
        }

        public void HomeMenuScreen()
        {
            Console.Clear();
            CommonMethods.WriteLine("Please enter an option to continue");
            CommonMethods.WriteLine("Enter 1 to find available products for a partenr on a given date");
            CommonMethods.WriteLine("Enter 2 to upload or manage Music Contracts");
            CommonMethods.WriteLine("Enter 3 to upload or manage Distribution Partner Contracts");
            CommonMethods.WriteLine("Enter 4 to view About");
            CommonMethods.WriteLine("Enter 5 to Exit");
            GetHomeScreenInput();
        }

        public void GetHomeScreenInput()
        {
            var input = CommonMethods.ReadLine();

            if (!testForValidInput(input))
            {
                Console.Clear();
                GetHomeScreenInput();
            }

            var userChoice = getInt(input);
            switch (userChoice)
            {
                case 1:
                    {
                        System.Console.WriteLine("Find Available products");
                        break;
                    }
                case 2:
                    {
                        System.Console.WriteLine("Manage Music Contracts");
                        break;
                    }
                case 3:
                    {
                        System.Console.WriteLine("Manage Distribution Contracts");
                        break;
                    }
                case 4:
                    {
                        _aboutPage.DisplayAbout();
                        HomeMenuScreen();
                        break;
                    }
                case 5:
                    {

                        Environment.Exit(1);
                         break;
                    }
                default:
                    {
                        System.Console.WriteLine("----");
                        break;
                    }
            }
        }

        private bool testForValidInput(string input)
        {
            //return false
            //If more than 1 Char
            if (input.Length != 1)
            {
                return false;
            }
            else if (input.All(Char.IsLetter))
            {
                return false;
            }
        }

        private bool lettersPresent(string myString)
        {
            return myString.All(Char.IsLetter);
        }

        private int getInt(string input)
        {
            return Int32.Parse(input);
        }
    }
}