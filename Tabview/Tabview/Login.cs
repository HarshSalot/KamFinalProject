using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Tabview
{
	[Activity(Label = "Login")]
	public class Login : Activity
	{
		Button btnLogin, btnLRegister;

		

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.Login);
			btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
			btnLRegister = FindViewById<Button>(Resource.Id.btnLRegister);

			btnLogin.Click += delegate
			{
				Intent i = new Intent(this, typeof(MainActivity));
				StartActivity(i);
			};
			btnLRegister.Click += delegate
			{
				Intent i = new Intent(this, typeof(Register));
				StartActivity(i);
			};

		}
	}
}