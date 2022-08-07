using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
{
    internal partial class FormLikedPages : Form
    {
        private readonly FacebookObjectCollection<Page> r_LikedPages;

        public FormLikedPages(FacebookObjectCollection<Page> i_LikedPages)
        {
            InitializeComponent();
            r_LikedPages = i_LikedPages;
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            foreach (Page likedPage in r_LikedPages)
            {
                listBoxLikedPages.Items.Add(likedPage);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(", 
                    "No Liked Pages", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Page selectedPage = listBoxLikedPages.SelectedItem as Page;

            pictureBoxSelectedLikedPage.LoadAsync(selectedPage.PictureNormalURL);
        }
    }
}
