using FB.GAP.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class CampaignForm : Form
    {
        public CampaignForm()
        {
            InitializeComponent();
        }

        private void BrowseImagesButton_Click(object sender, EventArgs e)
        {
            DialogResult result = ImagesFileDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string fileName in ImagesFileDialog.FileNames)
                {
                    ImagesListbox.Items.Add(fileName);  
                    //TODO: do this
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CampaignData data = new CampaignData();

            List<string> urls = new List<string>();
            foreach (var item in this.ImagesListbox.Items)
            {
                urls.Add(item.ToString());
            }

            bool result = data.SaveCampaign(new Campaign() { 
                CampaignName = this.CampaignNameTextbox.Text.Trim(),
                Description = this.DescriptionTextbox.Text.Trim(),
                Note = this.NoteTextbox.Text.Trim(),
                Price = this.PriceTextbox.Text.Trim(),
                Status = "Saved",
                Title = this.TitleTextbox.Text.Trim(),
                ImageUrls = urls    
            });

            if (result)
            {
                MessageBox.Show("Save Successful.");
                this.CampaignNameTextbox.Text = string.Empty;
                this.DescriptionTextbox.Text = string.Empty;
                this.NoteTextbox.Text = string.Empty;
                this.PriceTextbox.Text = string.Empty;
                this.TitleTextbox.Text = string.Empty;
                this.ImagesListbox.Items.Clear();
            }
        }
    }
}
