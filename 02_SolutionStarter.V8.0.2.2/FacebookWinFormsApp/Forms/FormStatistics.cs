using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormStatistics : Form
    {
        public User LoggedInUser { get; }

        public FormStatistics(User loggedInUser)
        {
            InitializeComponent();
            LoggedInUser = loggedInUser;
        }
    }
}
