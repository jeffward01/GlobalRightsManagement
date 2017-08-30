using System;
using System.Linq;
using System.Runtime.CompilerServices;
using GRM.UI_Inter.About;
using GRM.UI_Inter.MusicContracts;
using GRM.UI_Inter.PartnerContracts;

namespace GRM.UI_Inter.WelcomeMessage
{
    public class WelcomeInformation : IWelcomeInformation
    {

        private readonly IAboutPage _aboutPage;
        private readonly IMusicContractPage _musicContractPage;
        private readonly IPartnerContractPage _partnerContractPage;

        public WelcomeInformation(IAboutPage aboutPage, IMusicContractPage musicContract, IPartnerContractPage partnerContractPage)
        {
            _aboutPage = aboutPage;
            _musicContractPage = musicContract;
            _partnerContractPage = partnerContractPage;
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
            CommonMethods.Line();
            CommonMethods.Space();
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
                HomeMenuScreen();
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
                        _musicContractPage.DisplayMusicContractWelcome();
                        break;
                    }
                case 3:
                    {
                        _partnerContractPage.DisplayDistroPartnerContractsWelcome();
                        break;
                    }
                case 4:
                    {
                        Console.Clear();
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
                    HomeMenuScreen();
                        break;
                    }
            }
        }

        private bool testForValidInput(string input)
        {
            var result = false;
            //return false
            //If more than 1 Char
            if (input.Length != 1)
            {
                result = false;
            }
            else if (!input.All(Char.IsLetter))
            {
                result = true;
            }
            return result;
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