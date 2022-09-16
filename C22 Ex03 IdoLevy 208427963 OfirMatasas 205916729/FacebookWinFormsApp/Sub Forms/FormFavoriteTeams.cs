using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFavoriteTeams : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private Page[] m_FavoriteTeams;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormFavoriteTeams()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoFavoriteTeamsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoFavoriteTeamsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchFavoriteTeams();
            nofityTheUserIfThereAreNoFavoriteTeamsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchFavoriteTeams()
        {
            m_FavoriteTeams = FacebookAccountManager.Instance.FavoriteTeams;
            listBoxFavoriteTeams.Invoke(new Action(() => pageBindingSource.DataSource = m_FavoriteTeams));
        }

        private void nofityTheUserIfThereAreNoFavoriteTeamsToReceive()
        {
            if (m_FavoriteTeams == null)
            {
                MessageDisplayer.NoItemsAppearOnForm("favorite teams");
            }
        }
    }
}
