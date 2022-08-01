using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLikedPages : Form
    {
        public FacebookObjectCollection<Page> LikedPages { get; }

        public FormLikedPages(FacebookObjectCollection<Page> i_LikedPages)
        {
            InitializeComponent();
            LikedPages = i_LikedPages;
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.DisplayMember = "Name";
            foreach (Page page in LikedPages)
            {
                listBoxLikedPages.Items.Add(page);
            }
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            if (listBoxLikedPages.Items.Count == 0)
            {
                MessageBox.Show("No pages to retrieve :(");
            }
        }

        private void listBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Page selectedPage = listBoxLikedPages.SelectedItem as Page;

            pictureBoxSelectedLikedPage.LoadAsync(selectedPage.PictureNormalURL);
        }
    }
}
