using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormLikedPages : Form
    {
        private readonly FacebookObjectCollection<Page> r_LikedPages;

        public FormLikedPages()
        {
            InitializeComponent();
            r_LikedPages = FacebookAccountManager.Instance.LikedPages;
        }

        private void fetchLikedPages()
        {
            listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = r_LikedPages));
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(fetchLikedPages);
            if (r_LikedPages == null)
            {
                MessageDisplayer.NoItemsAppearOnForm("liked pages");
            }
        }
    }
}
