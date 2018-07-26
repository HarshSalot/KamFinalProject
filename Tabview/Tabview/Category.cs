using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Tabview
{
	public class Category : Fragment
	{
		Spinner myDropdownSpinner;
		string[] dropDownList = { "iPhone", "Android", "Google" };
		public override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			

			// Create your fragment here
		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			// return inflater.Inflate(Resource.Layout.YourFragment, container, false);

			View view = inflater.Inflate(Resource.Layout.category, container, false);

				
			
			/* Dropdown code */
			myDropdownSpinner = view.FindViewById<Spinner>(Resource.Id.spinner1);

			ArrayAdapter myDropdownAdapter = new ArrayAdapter(this.Context, Android.Resource.Layout.SimpleListItem1, dropDownList);

			myDropdownSpinner.Adapter = myDropdownAdapter;

			myDropdownSpinner.ItemSelected += mySpinnerViewIteamSelected;




			return view;
			
		}

		public void mySpinnerViewIteamSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{


			var value = dropDownList[e.Position];

			System.Console.WriteLine("Drop Down Iteam selected " + value);
			if (value.Equals("iPhone"))
			{
				Toast.MakeText(this.Context, "iphone", ToastLength.Short).Show();

			}
			else
			{
				Toast.MakeText(this.Context, "android", ToastLength.Short).Show();
			}

		}

	}
	
}