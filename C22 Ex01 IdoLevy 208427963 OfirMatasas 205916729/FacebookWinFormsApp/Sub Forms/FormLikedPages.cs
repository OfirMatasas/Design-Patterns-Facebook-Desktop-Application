using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormLikedPages : Form
    {
        private readonly FacebookObjectCollection<Page> r_LikedPages;

        public FormLikedPages()
        {
            InitializeComponent();
            r_LikedPages = FacebookAccountManager.Instance.User.LikedPages;
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            if (!listBoxLikedPages.InvokeRequired)
            {
                pageBindingSource.DataSource = r_LikedPages;
            }
            else
            {
                listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = r_LikedPages));
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
    }
}
