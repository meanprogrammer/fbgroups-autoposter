using FB.GAP.Library.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FB.GAP.Library
{
    public class GroupData
    {
        CampaignDataContext context = null;
        public GroupData()
        {
            context = new CampaignDataContext();
        }

        public bool SaveGroup(Group group)
        {
            context.Groups.InsertOnSubmit(
                new Data.Group() { 
                    GroupName = group.GroupName,
                    URL = group.URL
                });
            int affectRows = context.GetChangeSet().Inserts.Count;
            context.SubmitChanges();

            return affectRows > 0;
        }
    }
}
