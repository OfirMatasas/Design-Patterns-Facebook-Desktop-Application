using FacebookWinFormsLogic;
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
    public partial class FormMostPopularFeed : Form
    {
        private MostPopularFeedLogic m_MostPopularFeedLogic { get; }
        public FormMostPopularFeed(User i_LoggedInUser)
        {
            InitializeComponent();
            m_MostPopularFeedLogic = new MostPopularFeedLogic(i_LoggedInUser);
        }

        private void getMostPopularPost()
        {
            Post mostPopular = null;
            
            try
            {
                mostPopular = m_MostPopularFeedLogic.FindMostPopularPost(dateTimePickerChoosedYear.Value);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show($"Invalid date !{Environment.NewLine}Please choose a valid Year", "Invalid Date",
                    MessageBoxButtons.OK);
            }

            if (mostPopular != null)
            {
                int numberOfLikes = mostPopular.Comments.Count;

                listBoxMostPopularPost.Items.Clear();
                listBoxMostPopularPost.Items.Add(mostPopular);
                labelMostPopularPost.Text = $"{numberOfLikes} {(numberOfLikes == 1 ? " Like" : " Likes")} On Post";
                //published at:
            }
            else
            {
                MessageBox.Show($"This year you haven't published any post !", "No posts to show",
                    MessageBoxButtons.OK);
            }
        }

        private void buttonShowPhotosAndPosts_Click(object sender, EventArgs e)
        {
            panelMostPopular.Visible = true;
            getMostPopularPost();
        }
    }
}
