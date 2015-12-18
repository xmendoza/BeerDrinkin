using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.WindowsAzure.MobileServices;

namespace BeerDrinkin.Android
{
    [Activity(Label = "BeerDrinkin.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button btnSearchBeers;
        Core.ViewModels.SearchViewModel searchViewModel;
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CurrentPlatform.Init();
            Core.Helpers.Settings.UserTrackingEnabled = false;

            searchViewModel = new Core.ViewModels.SearchViewModel();

            // Get our button from the layout resource,
            // and attach an event to it
            btnSearchBeers = FindViewById<Button>(Resource.Id.MyButton);

            btnSearchBeers.Click += SearchBeer;
        }

        private async void SearchBeer(object sender, EventArgs e)
        {
            await searchViewModel.SearchForBeersCommand("duvel");
            //adapter.NotifyDataSetChanged();
        }
    }
}

