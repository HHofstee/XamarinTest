using Android.App;
using Android.OS;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace MyTunes
{
	[Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : ListActivity
	{
//        public static async Task<IEnumerable<Song>> Load()


        protected async override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

            var data = await SongLoader.Load();

            ListAdapter = new ListAdapter<Song>()
            {
                DataSource = data.ToList(),
                TextProc = s => s.Name,
                DetailTextProc = s => s.Artist + " - " + s.Album + " --- " + s.Year
            };

//			ListAdapter = new ListAdapter<string>() {
//				DataSource = new[] { "One", "Two", "Three" }
//			};
        }
	}
}


