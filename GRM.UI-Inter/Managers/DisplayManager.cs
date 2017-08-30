using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRM.UI_Inter.About;
using GRM.UI_Inter.MusicContracts;
using GRM.UI_Inter.PartnerContracts;
using GRM.UI_Inter.WelcomeMessage;

namespace GRM.UI_Inter.Managers
{
    public class DisplayManager : IDisplayManager
    {
        private readonly IMusicContractPage _musicContractPage;
        private readonly IPartnerContractPage _partnerContractPage;
        private readonly IAboutPage _aboutPage;
        private readonly IWelcomeInformation _welcomeInformation;
        public DisplayManager(IPartnerContractPage partnerContractPage, IMusicContractPage musicContract, IAboutPage aboutPage,IWelcomeInformation welcomeInformation)
        {
            _musicContractPage = musicContract;
            _partnerContractPage = partnerContractPage;
            _aboutPage = aboutPage;
            _welcomeInformation = welcomeInformation;
        }


        public void Home()
        {
            _welcomeInformation.DisplayIntro();
            _welcomeInformation.HomeMenuScreen();
            _welcomeInformation.GetHomeScreenInput();
        }

        public void GoToAbout()
        {
            _aboutPage.DisplayAbout();
        }

        public void GoToMusicContractPage()
        {
            _musicContractPage.DisplayMusicContractWelcome();
        }

        public void GoToDistroPartnerPage()
        {
            _partnerContractPage.DisplayDistroPartnerContractsWelcome();
        }
    }
}
