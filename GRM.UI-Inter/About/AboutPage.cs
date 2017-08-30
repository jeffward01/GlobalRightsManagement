using System;

namespace GRM.UI_Inter.About
{
    public class AboutPage : IAboutPage
    {
        public void DisplayAbout()
        {
            CommonMethods.WriteLine("About GRM");
            CommonMethods.Line();
            CommonMethods.Space();
            CommonMethods.WriteLine("GRM is Global Rights Management system that manages contracts with Music Artists and Distrubuition Partners.");
            CommonMethods.Space();
            CommonMethods.WriteLine("GRM allows users to upload and save contracts with Music Artists and Distrubuition Partners.  The User can then determine which products are available for a given partner on a given date.");
            CommonMethods.Space();
            CommonMethods.WriteLine("To Search (First ensure you have uploaded the proper documents if not already saved in the application:");
            CommonMethods.WriteLine("Enter a partner name and format in this format:");
            CommonMethods.WriteLine("example 1:  ITunes 1st March 2012");
            CommonMethods.SpaceSm();
            CommonMethods.WriteLine("an example output from the search is:");
            CommonMethods.Space();
            CommonMethods.WriteLine("Artist|Title|Usage|StartDate|EndDate");
            CommonMethods.WriteLine("Monkey Claw|Black Mountain|digital download|1st Feb 2012|");
            CommonMethods.WriteLine("Monkey Claw|Motor Mouth|digital download|1st Mar 2011|");
            CommonMethods.WriteLine("Tinie Tempah|Frisky (Live from SoHo)|digital download|1st Feb 2012|");
            CommonMethods.WriteLine("Tinie Tempah|Miami 2 Ibiza|digital download|1st Feb 2012|");
            CommonMethods.Line();
            CommonMethods.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}