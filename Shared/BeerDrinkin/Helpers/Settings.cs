// Helpers/Settings.cs
using Plugin.Settings.Abstractions;
using Plugin.Settings;

namespace BeerDrinkin.Core.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }

        #region Setting Constants

        private const string UserTrackingEnabledName = "user_tracking_enabled";
        private static readonly bool UserTrackingEnabledDefault = true;

        private const string StoreLoginCredentialsName = "store_login_credentials_name";
        private static readonly bool StoreLoginCredentialsDefault = true;

        private const string FirstRunName = "first_run";
        private static readonly bool FirstRunDefault = true;

        private const string FacebookTokenName = "facebookToken";
        private static readonly string FacebookTokenDefault = string.Empty;

        private const string GoogleTokenName = "googleToken";
        private static readonly string GoogleTokenDefault = string.Empty;

        #endregion

        public static bool UserTrackingEnabled
        {
            get { return AppSettings.GetValueOrDefault<bool>(UserTrackingEnabledName, UserTrackingEnabledDefault); }
            set { AppSettings.AddOrUpdateValue<bool>(UserTrackingEnabledName, value); }
        }

        public static bool StoreLoginCredentials
        {
            get { return AppSettings.GetValueOrDefault<bool>(StoreLoginCredentialsName, StoreLoginCredentialsDefault); }
            set { AppSettings.AddOrUpdateValue<bool>(StoreLoginCredentialsName, value); }
        }

        public static bool FirstRun
        {
            get { return AppSettings.GetValueOrDefault<bool>(FirstRunName, FirstRunDefault); }
            set { AppSettings.AddOrUpdateValue<bool>(FirstRunName, value); }
        }

        public static string FacebookToken
        {
            get { return AppSettings.GetValueOrDefault<string>(FacebookTokenName, FacebookTokenDefault); }
            set { AppSettings.AddOrUpdateValue<string>(FacebookTokenName, value); }
        }

        public static string GoogleToken
        {
            get { return AppSettings.GetValueOrDefault<string>(GoogleTokenName, GoogleTokenDefault); }
            set { AppSettings.AddOrUpdateValue<string>(GoogleTokenName, value); }
        }

    }
}