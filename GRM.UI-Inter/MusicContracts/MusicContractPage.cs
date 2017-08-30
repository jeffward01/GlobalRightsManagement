using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GRM.FileTxt.Service;
using GRM.Models;

namespace GRM.UI_Inter.MusicContracts
{
    public class MusicContractPage : IMusicContractPage
    {
        private readonly IFileService _fileService;

       
        public MusicContractPage(IFileService fileService)
        {
            _fileService = fileService;
        }
        public void DisplayMusicContractWelcome()
        {
            Console.Clear();
            CommonMethods.WriteLine("_____Music Contracts_____");
            CommonMethods.SpaceLg();
            CommonMethods.Line();
            if (checkForUploadedMusicContracts())
            {
                //show contracts if they exist
                displayUploadedContracts();
                displayUploadExitPrompt();
            }
            else
            {
                //Display prompt to upload contracts
                CommonMethods.WriteLine("No contracts have been added!");
                displayUploadExitPrompt();
            }
        }

        //display contarcts  
        private void displayUploadedContracts()
        {
            CommonMethods.WriteLine("Current Contracts:");
            CommonMethods.WriteLine("Artist|Title|Usages|StartDate|EndDate");
            CommonMethods.Line();
            foreach (var musicContract in GRMContracts.MusicContracts)
            {
                var musicUsageString = buildMusicUsages(musicContract);
                CommonMethods.WriteLine(musicContract.ArtistName + " | " + musicContract.Title + " | " +
                                        musicUsageString + " | " + musicContract.StartDate + " | " +
                                        musicContract.EndDate);
            }
        }


        private string buildMusicUsages(MusicContract musicContract)
        {
            var myString = "";
            var index = 0;
            foreach (var m in musicContract.Usages)
            {
                myString += m;
                if (index != musicContract.Usages.Count)
                {
                    myString += ", ";
                }
                index++;
            }
            return myString;
        }

        //show upload area
        private void displayUploadExitPrompt()
        {
            CommonMethods.WriteLine("Please enter 'u' to upload a contract, or press '0' to Exit:");

            var userInput = Console.ReadLine();
            var validInput = isValidInput(userInput);

            while (!validInput)
            {
                validInput = isValidInput(userInput);
                DisplayMusicContractWelcome();
            }

            if (userInput.All(Char.IsDigit))
            {
                if (Convert.ToInt32(userInput) == 0)
                {
                    Environment.Exit(0);
                }
            }

            string selectedPath;
            var t = new Thread((ThreadStart)(() => {
                Stream myStream = null;

                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Filter = "Text|*.txt|All|*.*";
                theDialog.FilterIndex = 1;
                
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if ((myStream = theDialog.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                string directoryPath = Path.GetFullPath(theDialog.FileName);
                                string text2 = FileTools.ReadFileString(directoryPath);
                                _fileService.confirmMusicContractValidFormat(text2, directoryPath);
                                Console.WriteLine(text2);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }));

            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();
       

            CommonMethods.Line();
            CommonMethods.SpaceMed();
            CommonMethods.WriteLine("Display Upload Prompt");
        }



        private bool isValidInput(string myString)
        {
            if (myString.Length != 1)
            {
                return false;
            }
            if (myString.All(Char.IsDigit))
            {
                if (Convert.ToInt32(myString) == 0)
                {
                    return true;
                }
            }
            return myString.ToLower() == "u";
        }

    private bool checkForUploadedMusicContracts()
        {
            if (GRMContracts.MusicContracts != null)
            {
                return GRMContracts.MusicContracts.Count > 0;
            }
            return false;
        }
    }
    public static class FileTools
    {
        public static string ReadFileString(string path)
        {
            // Use StreamReader to consume the entire text file.
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
