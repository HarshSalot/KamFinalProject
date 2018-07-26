using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Views;
using System;

namespace Tabview
{
    [Activity(Label = "@string/app_name")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.activity_main);


			//enable navigation mode to support tab layout
			this.ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;


			AddMyTab("Home",Resource.Drawable.house, new Home());

			AddMyTab("Category", Resource.Drawable.home, new Category());

			//AddMyTab("Name", Resource.Drawable.home, new ByName());

			//AddMyTab("MyCart", Resource.Drawable.home, new MyCart());


        }


		void AddMyTab(string tabTitle, int iconResourceId, Fragment fragment)
        {
            var tab = this.ActionBar.NewTab();
			tab.SetText(tabTitle);
			tab.SetIcon(iconResourceId);

			tab.SetCustomView(Resource.Layout.TabLayout);
            tab.CustomView.FindViewById<TextView>(Resource.Id.myTabTitle).Text = tabTitle;

            // must set event handler for replacing tabs tab
            tab.TabSelected += delegate (object sender, Android.App.ActionBar.TabEventArgs e) {

                e.FragmentTransaction.Replace(Resource.Id.fragmentContainer, fragment);
            };

            this.ActionBar.AddTab(tab);
        }

    }
}
