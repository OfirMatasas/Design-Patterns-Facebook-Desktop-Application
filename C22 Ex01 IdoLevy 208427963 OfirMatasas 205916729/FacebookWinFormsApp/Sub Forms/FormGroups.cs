using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormGroups : Form
    {
        private readonly FacebookObjectCollection<Group> r_Groups;

        public FormGroups(FacebookObjectCollection<Group> i_Groups)
        {
            InitializeComponent();
            r_Groups = i_Groups;
            fetchGroups();
        }

        private void fetchGroups()
        {
            listBoxGroups.Text = Name;

            foreach (Group group in r_Groups)
            {
                listBoxGroups.Items.Add(group);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxGroups.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("groups");
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
            richTextBoxGroupSelectedDescription.Text = string.Format("{0}{1}{1}", i_SelectedGroup.Name, Environment.NewLine);
            richTextBoxGroupSelectedDescription.Text = i_SelectedGroup.Description;
            richTextBoxGroupSelectedDescription.Visible = true;
            labelDescription.Visible = true;
        }
    }
}
