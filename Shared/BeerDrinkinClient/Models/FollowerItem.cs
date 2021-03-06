﻿using System;

namespace BeerDrinkin.Models
{
    public class FollowerItem : EntityData
    {
        public string Username { get; set; }

        public string FollowedBy { get; set; }

        public static FollowerItem NewFollowerItem(string usernameToFollow, string follower)
        {
            var id = string.Format("{0}-{1}", usernameToFollow, follower);
            return new FollowerItem
            {
                Username = usernameToFollow,
                FollowedBy = follower,
                Id = id
            };
        }
    }
}