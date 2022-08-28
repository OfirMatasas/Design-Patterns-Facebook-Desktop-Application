using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormFavoriteTeams : Form
    {
        private readonly Page[] r_FavoriteTeams;

        public FormFavoriteTeams()
        {
            InitializeComponent();
            r_FavoriteTeams = FacebookAccountManager.Instance.FavoriteTeams;
        }

        private void fetchFavoriteTeams()
        {
            listBoxFavoriteTeams.Invoke(new Action(() => pageBindingSource.DataSource = r_FavoriteTeams));
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            fetchFavoriteTeams();
            if (listBoxFavoriteTeams.Items.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("favorite teams");
            }
        }
    }
}
