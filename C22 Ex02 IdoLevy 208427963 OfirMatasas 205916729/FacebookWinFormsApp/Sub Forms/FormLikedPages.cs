using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormLikedPages : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<Page> m_LikedPages;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormLikedPages()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoLikedPagesToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoLikedPagesToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchLikedPages();
            nofityTheUserIfThereAreNoLikedPagesToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchLikedPages()
        {
            m_LikedPages = FacebookAccountManager.Instance.LikedPages;
            listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = m_LikedPages));
        }

        private void nofityTheUserIfThereAreNoLikedPagesToReceive()
        {
            if (m_LikedPages.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("liked pages");
            }
        }
    }
}
