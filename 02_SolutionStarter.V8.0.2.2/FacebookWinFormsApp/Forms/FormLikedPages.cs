using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        public User User { get; set; }

        public FormLikedPages(User i_User)
        {
            InitializeComponent();
            User = i_User;
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Items.Clear();
            listBoxLikedPages.DisplayMember = "Name";

            try
            {
                foreach (Page page in User.LikedPages)
                {
                    listBoxLikedPages.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }

        private void buttonFetchLikedPages_Click(object sender, EventArgs e)
        {
            fetchLikedPages();
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItems.Count == 1)
            {
                Page selectedPage = listBoxLikedPages.SelectedItem as Page;
                pictureBoxSelectedLikedPage.LoadAsync(selectedPage.PictureNormalURL);
            }
        }
    }
}
