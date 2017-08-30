using GRM.Models;

namespace GRM.FileTxt.Service
{
    public class FileService : IFileService
    {
        public bool confirmMusicContractValidFormat(string myString, string path)
        {
            var x = myString.IndexOf("\n");
            var fileType = myString.Substring(0, x);
            var index = fileType.LastIndexOf("/");
            if (index > 0)
                fileType = fileType.Substring(0, index);
            fileType = fileType.Trim();


            if (fileType == "Music Contracts")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public MusicContract GetMusicContractFromFile(string myString)
        {
            return new MusicContract();
        }

        public bool confirmDistroPartnerContractValidFormat(string myString, string path)
        {
            return false;
        }

        public DistributionPartnerContract GetDistributionPartnerContractFromFile(string myString)
        {
            return new DistributionPartnerContract();
        }
    }
}