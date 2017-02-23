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
    public partial class GroupsForm : Form
    {
        public GroupsForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            GroupData data = new GroupData();
            bool result = data.SaveGroup(
                new Group() { 
                    GroupName = this.GroupNameTextbox.Text.Trim(),
                    URL = this.URLTextbox.Text.Trim()
                }
                );

            if (result)
            {
                MessageBox.Show("Save Successful.");
                this.URLTextbox.Text = string.Empty;
                this.GroupNameTextbox.Text = string.Empty;
            }
        }
    }
}
