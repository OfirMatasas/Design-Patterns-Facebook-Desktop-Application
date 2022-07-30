using System;
using System.Text;
using System.Windows.Forms;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormPosts : Form
    {
        private FacebookAccountManager m_LoggedInUser;

        public FormPosts(FacebookAccountManager i_LoggedInUser)
        {
            InitializeComponent();
            initializePostsView(i_LoggedInUser.LoggedInUser.Posts);

            m_LoggedInUser = i_LoggedInUser;
        } 

        private void initializePostsView(FacebookObjectCollection<Post> i_Posts)
        {
            foreach (Post post in i_Posts)
            {
                listBoxPosts.Items.Add(post);
            }

            listBoxPosts.Show();
        }

        private void buttonClearNewPostText_Click(object i_Sender, EventArgs i_E)
        {
            richTextBoxNewPost.Text = string.Empty;
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;
            StringBuilder postInformation = new StringBuilder();

            postInformation.Append(selectedPost?.Message).Append(Environment.NewLine).Append(Environment.NewLine);
            postInformation.Append(selectedPost?.CreatedTime);
            richTextBoxSelectedPost.Text = postInformation.ToString();
            pictureBoxSelectedPostPicture.ImageLocation = selectedPost?.PictureURL;
        }

        private void richTextBoxNewPost_TextChanged(object i_Sender, EventArgs i_E)
        {
            RichTextBox newPost = i_Sender as RichTextBox;
            bool newPostIsEmpty = string.IsNullOrEmpty(newPost?.Text);

            buttonClearNewPostText.Enabled = !newPostIsEmpty;
            buttonPost.Enabled = !newPostIsEmpty;
        }

        private void buttonPost_Click(object i_Sender, EventArgs i_E)
        {
            Status postedStatus;

            if(string.IsNullOrEmpty(richTextBoxNewPost?.Text))
            {
                MessageBox.Show("Cannot post an empty post!");
            }
            else
            {
                postedStatus = m_LoggedInUser.Post(richTextBoxNewPost.Text);
                MessageBox.Show(postedStatus.Message);
            }
        }
    }
}
