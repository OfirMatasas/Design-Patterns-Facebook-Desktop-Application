using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.Forms
{
    public partial class FormFriends : Form
    {
        private FacebookObjectCollection<User> m_Friends;

        public FormFriends(FacebookObjectCollection<User> i_Friends)
        {
            InitializeComponent();
            m_Friends = i_Friends;
        }




    }
}
