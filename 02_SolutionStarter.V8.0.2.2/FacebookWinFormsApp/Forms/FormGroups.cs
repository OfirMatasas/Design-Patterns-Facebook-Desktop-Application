using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormGroups : Form
    {
        public User User { get; set; }

        public FormGroups(User i_User)
        {
            InitializeComponent();
            User = i_User;
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = "Name";

            try
            {
                foreach (Group group in User.Groups)
                {
                    listBoxGroups.Items.Add(group);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void buttonFetchGroups_Click(object sender, EventArgs e)
        {
            fetchGroups();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                richTextBoxGroupSelectedDescription.Visible = true;
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxSelectedGroup.LoadAsync(selectedGroup.PictureNormalURL);
                richTextBoxGroupSelectedDescription.Text = selectedGroup.Description;
            }
        }
    }
}
