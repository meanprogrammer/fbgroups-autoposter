using FB.GAP.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.GAP.Library
{
    public class CampaignData
    {
        CampaignDataContext context = null;
        public CampaignData()
        {
            context = new CampaignDataContext();
        }

        public bool SaveCampaign(Campaign campaign)
        {
            Data.Campaign d = new Data.Campaign();
            d.CampaignName = campaign.CampaignName;
            d.Description = campaign.Description;
            d.Note = campaign.Note;
            d.Price = campaign.Price;
            d.Status = campaign.Status;
            d.Title = campaign.Title;

           

            context.Campaigns.InsertOnSubmit(d);
            int affectRows = context.GetChangeSet().Inserts.Count;

            context.SubmitChanges();
            
            foreach (var url in campaign.ImageUrls)
            {
                context.CampaignImages.InsertOnSubmit(new CampaignImage() { 
                    ImageUrl = url,
                    ParentID = d.ID
                });
            }

            int affectRows2 = context.GetChangeSet().Inserts.Count;
            context.SubmitChanges();

            return affectRows > 0 && affectRows2 > 0;

        }
    }
}
