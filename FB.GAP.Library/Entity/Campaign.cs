using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.GAP.Library
{
    public class Campaign
    {
        public int ID { get; set; }
        public string CampaignName { get; set; }
        public string Title { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

        public List<string> ImageUrls { get; set; }
    }
}
