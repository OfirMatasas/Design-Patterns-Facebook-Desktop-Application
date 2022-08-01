using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormGroups : Form
    {
        public FacebookObjectCollection<Group> Groups { get; }

        public FormGroups(FacebookObjectCollection<Group> i_Groups)
        {
            InitializeComponent();
            Groups = i_Groups;
            fetchGroups();
        }

        private void fetchGroups()
        {
            listBoxGroups.DisplayMember = "Name";
            foreach (Group group in Groups)
            {
                listBoxGroups.Items.Add(group);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void listBoxGroups_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Group selectedGroup = listBoxGroups.SelectedItem as Group;

            displaySelectedGroupPicture(selectedGroup);
            displaySelectedGroupDescription(selectedGroup);
        }

        private void displaySelectedGroupDescription(Group i_SelectedGroup)
        {
            pictureBoxSelectedGroup.LoadAsync(i_SelectedGroup.PictureNormalURL);
        }

        private void displaySelectedGroupPicture(Group i_SelectedGroup)
        {
            richTextBoxGroupSelectedDescription.Text = i_SelectedGroup.Description;
            richTextBoxGroupSelectedDescription.Visible = true;
        }
    }
}
