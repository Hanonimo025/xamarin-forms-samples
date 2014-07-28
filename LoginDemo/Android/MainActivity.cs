﻿using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;
using LoginPattern;

namespace LoginPattern.Android
{
	[Activity (Label = "LoginPattern.Android.Android", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : AndroidActivity, ILoginManager
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			Xamarin.Forms.Forms.Init (this, bundle);

			SetPage (App.GetLoginPage (this));
		}

	
		#region ILoginManager implementation

		public void ShowMainPage ()
		{
			SetPage (App.GetMainPage ()); 
		}

		public void Logout() 
		{
			SetPage (App.GetLoginPage (this)); 
		}
		#endregion
	}
}
