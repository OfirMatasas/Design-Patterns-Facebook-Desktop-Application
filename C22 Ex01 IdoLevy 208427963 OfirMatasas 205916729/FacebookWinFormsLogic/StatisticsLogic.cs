﻿using FacebookWrapper.ObjectModel;
using System;

namespace FacebookWinFormsLogic
{
    public class StatisticsLogic
    {
        public User LoggedInUser { get; }
        public StatisticsLogic(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
        }

        public void AnalyzeDataOnAlbumsAndPhotosInChosenDate(DateTime i_Date, out int o_NumberOfLikesOnPhotos,
            out int o_NumberOfNewAlbums, out int o_NumberOfNewPhotos)
        {
            o_NumberOfLikesOnPhotos = 0;
            o_NumberOfNewAlbums = 0;
            o_NumberOfNewPhotos = 0;

            foreach (Album album in LoggedInUser.Albums)
            {
                if (album.CreatedTime.Value.Month == i_Date.Month
                    && album.CreatedTime.Value.Year == i_Date.Year)
                {
                    o_NumberOfNewAlbums += 1;
                }

                foreach (Photo photo in album.Photos)
                {
                    if (photo.CreatedTime.Value.Month == i_Date.Month
                    && photo.CreatedTime.Value.Year == i_Date.Year)
                    {
                        o_NumberOfLikesOnPhotos += photo.LikedBy.Count;
                        o_NumberOfNewPhotos += 1;
                    }
                }
            }
        }

        public int CalculateNumberOfPostsInChosenDate(DateTime i_Date)
        {
            int numberOfPosts = 0;

            foreach (Post post in LoggedInUser.Posts)
            {
                if (post.CreatedTime.Value.Month == i_Date.Month
                    && post.CreatedTime.Value.Year == i_Date.Year)
                {
                    numberOfPosts++;
                }
            }

            return numberOfPosts;
        }
    }
}