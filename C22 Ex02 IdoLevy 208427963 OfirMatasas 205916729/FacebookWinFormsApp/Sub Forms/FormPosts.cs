using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;
using System;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormPosts : Form
    {
        private readonly FacebookObjectCollection<Post> r_Posts;

        public FormPosts()
        {
            InitializeComponent();
            r_Posts = FacebookAccountManager.Instance.Posts;
        }

        protected override void OnShown(EventArgs i_E)
        {
            base.OnShown(i_E);
            new Thread(fetchPosts).Start();
            if (r_Posts == null)
            {
                MessageDisplayer.NoItemsAppearOnForm("posts");
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = r_Posts));
        }

        private void buttonClearNewPostText_Click(object i_Sender, EventArgs i_E)
        {
            richTextBoxNewPost.Text = string.Empty;
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
                    postedStatus = FacebookAccountManager.Instance.Post(richTextBoxNewPost.Text);
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
