﻿using System;
using System.Text;
using System.Windows.Forms;
using FacebookWinFormsLogic;
using FacebookWrapper.ObjectModel;

namespace FaceBookWinFormsApp.Forms
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
            foreach (Post post in r_LoggedInUser.LoginResult.LoggedInUser.Posts)
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
            richTextBoxNewPost.Visible = true;
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

            if(string.IsNullOrEmpty(richTextBoxNewPost?.Text))
            {
                MessageBox.Show("Cannot post an empty post!", "Empty Post", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    postedStatus = r_LoggedInUser.Post(richTextBoxNewPost.Text);
                    MessageBox.Show(postedStatus.Message);
                }
                catch
                {
                    MessageBox.Show("Cannot success to post.", "Posting Action Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
