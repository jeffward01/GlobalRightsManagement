using System;
using System.Collections.Generic;

namespace GRM.Models
{
    public class MusicContract
    {
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public List<Usage> Usages { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}