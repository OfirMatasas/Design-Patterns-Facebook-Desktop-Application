using BasicFacebookFeatures;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
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
            listBoxLikedPages.Text = Name;

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
                MessageDisplayer.NoItemsAppearOnForm("liked pages");
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Page selectedPage = listBoxLikedPages.SelectedItem as Page;

            pictureBoxSelectedLikedPage.LoadAsync(selectedPage.PictureNormalURL);
        }
    }
}
