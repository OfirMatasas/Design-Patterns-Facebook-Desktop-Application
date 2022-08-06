using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormGroups : Form
    {
        private FacebookObjectCollection<Group> m_Groups;

        public FormGroups(FacebookObjectCollection<Group> i_Groups)
        {
            InitializeComponent();
            m_Groups = i_Groups;
            fetchGroups();
        }

        private void fetchGroups()
        {
            foreach (Group group in m_Groups)
            {
                listBoxGroups.Items.Add(group);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve: (", "No Groups", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            labelPicture.Visible = true;
        }

        private void displaySelectedGroupPicture(Group i_SelectedGroup)
        {
            richTextBoxGroupSelectedDescription.Text = i_SelectedGroup.Description;
            richTextBoxGroupSelectedDescription.Visible = true;
            labelDescription.Visible = true;
        }
    }
}
