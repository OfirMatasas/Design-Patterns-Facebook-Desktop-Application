using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormProfile : Form
    {
        public FormProfile(User i_User)
        {
            InitializeComponent();
            DisplayProfileInfo(i_User);
        }

        private void DisplayProfileInfo(User i_User)
        {
            labelProfileName.Text = i_User.Name;
            pictureBoxProfilePicture.Image = i_User.ImageLarge;

        }
    }
}
