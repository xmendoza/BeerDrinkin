﻿using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using Xamarin;

namespace BeerDrinkin.Core.ViewModels
{
    public class SendFeedbackViewModel
    {
        public SendFeedbackViewModel()
        {
        }

        public int UserInterfaceRating { get; set; }

        public int BeerSelectionRating { get; set; }

        public string Feedback { get; set; }

        public async void SendFeedback()
        {
            var currentUser = await Client.Instance.BeerDrinkinClient.CurrentUser;
            Insights.Track("Feedback Provided", new Dictionary<string, string>
                {
                    { "User", currentUser.Email},
                    { "UI Rating", UserInterfaceRating.ToString() },
                    { "Beer Selection", BeerSelectionRating.ToString() },
                    { "Comment", Feedback }
                });

            Acr.UserDialogs.UserDialogs.Instance.ShowSuccess("Feedback sent!");
        }
    }
}

