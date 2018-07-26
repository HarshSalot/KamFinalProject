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
using Realms;

namespace Tabview
{
	[Activity(Label = "Register")]
	public class Register : Activity
	{
		Realm myDB;
		EditText txtName,txtAge,txtGender,txtMobile,txtEmail,txtAddress,txtPass;
		Button btnRegister;
		TextView txtLogIn;
		String M;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Create your application here
			SetContentView(Resource.Layout.Register);

			txtName = FindViewById<EditText>(Resource.Id.txtName);
			txtAge = FindViewById<EditText>(Resource.Id.txtAge);
			txtGender = FindViewById<EditText>(Resource.Id.txtGender);
			txtMobile = FindViewById<EditText>(Resource.Id.txtMobile);
			txtEmail = FindViewById<EditText>(Resource.Id.txtEmail);
			txtAddress = FindViewById<EditText>(Resource.Id.txtAddress);
			txtPass = FindViewById<EditText>(Resource.Id.txtPassword);

            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
			txtLogIn = FindViewById<TextView>(Resource.Id.txtLogIn);
			myDB = Realm.GetInstance();


			btnRegister.Click += delegate
			{
				if (txtName.Text == "")
				{
					M = "Please enter Name";
					Alert();
				}
				else if (txtAge.Text == "")
				{
					M = "Please enter valid Age";
					Alert();
				}
				else if (txtGender.Text == "")
				{
					M = "Please enter Gender";
					Alert();
				}
				else if (txtMobile.Text == "")
				{
					M = "Please enter valid Mobile No.";
					Alert();
				}
				else if (txtEmail.Text == "")
				{
					M = "Please enter valid Email";
					Alert();
				}
				else if (txtAddress.Text == "")
				{
					M = "Please enter Address";
					Alert();
				}
				else if (txtPass.Text == "")
				{
					M = "Please enter Password";
					Alert();
				}
				else
				{
					var Register = new ModelRegister();

					Register.name = txtName.Text;
					Register.age = txtAge.Text;
					Register.gender = txtGender.Text;
					Register.mobile = txtMobile.Text;
					Register.email = txtEmail.Text;
					Register.address = txtAddress.Text;
					Register.password = txtPass.Text;
					
					myDB.Write(() =>
					{
						myDB.Add(Register);
					});

					Intent next = new Intent(this, typeof(Login));
					/*	next.PutExtra("email", txtEmail.Text);
						next.PutExtra("pass", txtPass.Text);
						*/
					StartActivity(next);


				}
			};

			txtLogIn.Click += delegate
			{
				Intent login = new Intent(this, typeof(Login));
				StartActivity(login);
			};


		}
		private void Alert()
		{
			Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(this);
			alert.SetTitle("Error");
			alert.SetMessage(M);
			alert.SetPositiveButton("ok", (senderAiert, args) => {
				//Toast.MakeText(this, "Empty", ToastLength.Long).Show();
			});
			Dialog dialog = alert.Create();
			dialog.Show();

		}
	}
}
