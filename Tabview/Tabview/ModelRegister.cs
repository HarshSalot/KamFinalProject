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
	[Activity(Label = "ModelRegister")]
	public class ModelRegister : RealmObject
	{

		public string name { get; set; }
		public string age { get; set; }
		public string gender { get; set; }
		public string mobile { get; set; }
		public string email { get; set; }
		public string address { get; set; }
		public string password { get; set; }



	}
}

