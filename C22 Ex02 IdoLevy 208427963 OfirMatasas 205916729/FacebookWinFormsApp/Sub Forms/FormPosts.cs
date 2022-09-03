using System;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsApp.Forms
{
    internal partial class FormPosts : Form
    {
        //---------------------------------------------- Members ----------------------------------------------//
        private FacebookObjectCollection<Post> m_Posts;

        //-------------------------------------------- Constructor --------------------------------------------//
        public FormPosts()
        {
            InitializeComponent();
        }

        //--------------------------------------------- On Shown ----------------------------------------------//
        protected override void OnShown(EventArgs i_E)
        {
            new Thread(fetchEventsAndNotifyTheUserIfThereAreNoPostsToRecieve).Start();
            base.OnShown(i_E);
        }

        private void fetchEventsAndNotifyTheUserIfThereAreNoPostsToRecieve()
        {
            Cursor.Current = Cursors.WaitCursor;
            fetchPosts();
            nofityTheUserIfThereAreNoPostsToReceive();
            Cursor.Current = Cursors.Default;
        }

        private void fetchPosts()
        {
            m_Posts = FacebookAccountManager.Instance.Posts;
            listBoxPosts.Invoke(new Action(() => postBindingSource.DataSource = m_Posts));
        }

        private void nofityTheUserIfThereAreNoPostsToReceive()
        {
            if (m_Posts.Count == 0)
            {
                MessageDisplayer.NoItemsAppearOnForm("posts");
            }
        }

        //---------------------------------------------- Methods ----------------------------------------------//
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
