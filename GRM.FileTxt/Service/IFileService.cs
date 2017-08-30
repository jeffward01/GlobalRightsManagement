using GRM.Models;

namespace GRM.FileTxt.Service
{
    public interface IFileService
    {
        bool confirmMusicContractValidFormat(string myString, string path);
        MusicContract GetMusicContractFromFile(string myString);
        bool confirmDistroPartnerContractValidFormat(string myString, string path);
        DistributionPartnerContract GetDistributionPartnerContractFromFile(string myString);
    }
}