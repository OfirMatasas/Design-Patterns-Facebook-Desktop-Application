using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Text;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormPosts : Form
    {
        private readonly FacebookAccountManager r_LoggedInUser;

        public FormPosts(FacebookAccountManager i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            fetchPosts();
        }

        private void fetchPosts()
        {
            listBoxPosts.Text = Name;

            foreach (Post post in r_LoggedInUser.User.Posts)
            {
                listBoxPosts.Items.Add(post);
            }
        }

        private void buttonClearNewPostText_Click(object i_Sender, EventArgs i_E)
        {
            richTextBoxNewPost.Text = string.Empty;
        }

        private void listBoxPosts_SelectedIndexChanged(object i_Sender, EventArgs i_E)
        {
            Post selectedPost = listBoxPosts.SelectedItem as Post;

            displaySelectedPostPicture(selectedPost);
            displaySelectedPostInformation(selectedPost);
        }

        private void displaySelectedPostInformation(Post i_SelectedPost)
        {
            StringBuilder postInformation = new StringBuilder();

            postInformation.AppendFormat("{0}{1}{1}", i_SelectedPost?.Message, Environment.NewLine);
            postInformation.Append(i_SelectedPost?.CreatedTime);
            richTextBoxSelectedPost.Text = postInformation.ToString();
            richTextBoxSelectedPost.Visible = true;
        }

        private void displaySelectedPostPicture(Post i_SelectedPost)
        {
            pictureBoxSelectedPostPicture.ImageLocation = i_SelectedPost?.PictureURL;
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

            if (string.IsNullOrEmpty(richTextBoxNewPost?.Text))
            {
                MessageDisplayer.CannotBeEmpty("post", "post");
            }
            else
            {
                try
                {
                    postedStatus = r_LoggedInUser.Post(richTextBoxNewPost.Text);
                    MessageDisplayer.ActionSucceeded(postedStatus.Message);
                }
                catch
                {
                    MessageDisplayer.ActionFailed("posting");
                }
            }
        }
    }
}
