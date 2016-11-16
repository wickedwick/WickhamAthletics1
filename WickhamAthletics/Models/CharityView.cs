using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WickhamAthletics.Models
{
    public class CharityView
    { 
        public string Title { get; set; }

        public string Heading { get; set; }

        public List<DonationTypes> DonationTypes { get; set; }
    }
}