using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormGroups : Form
    {
        private readonly FacebookObjectCollection<Group> r_Groups;

        public FormGroups()
        {
            InitializeComponent();
            r_Groups = FacebookAccountManager.Instance.User.Groups;
            fetchGroups();
        }

        private void fetchGroups()
        {
            if (!listBoxGroups.InvokeRequired)
            {
                groupBindingSource.DataSource = r_Groups;
            }
            else
            {
                listBoxGroups.Invoke(new Action(() => groupBindingSource.DataSource = r_Groups));
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
    }
}
