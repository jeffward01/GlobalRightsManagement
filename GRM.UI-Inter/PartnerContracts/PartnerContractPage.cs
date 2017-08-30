using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GRM.Models;

namespace GRM.UI_Inter.PartnerContracts
{
    public class PartnerContractPage : IPartnerContractPage
    {
        public void DisplayDistroPartnerContractsWelcome()
        {
            CommonMethods.WriteLine("_____Distribution Partner Contracts_____");
            CommonMethods.SpaceLg();
            CommonMethods.Line();
            if (checkForUploadedMusicContracts())
            {
                //show contracts if they exist
                displayUploadedContracts();
                displayUploadPrompt();
            }
            else
            {
                //Display prompt to upload contracts
                CommonMethods.WriteLine("No Distribution Partner Contracts have been added!");
                displayUploadPrompt();
            }
        }

        //display contarcts  
        private void displayUploadedContracts()
        {
            CommonMethods.WriteLine("Current Distribution Partner Contracts:");
            CommonMethods.WriteLine("Partner|Usage");
            CommonMethods.Line();
            foreach (var distroContract in GRMContracts.DistributionPartnerContracts)
            {
                CommonMethods.WriteLine(distroContract.Partner + " | " + distroContract.Usage);
            }
        }



        //show upload area
        private void displayUploadPrompt()
        {
            CommonMethods.Line();
            CommonMethods.SpaceLg();
            CommonMethods.WriteLine("Display Upload Prompt");
        }

        private bool checkForUploadedMusicContracts()
        {
            return GRMContracts.DistributionPartnerContracts.Count > 0;
        }
    }
}

