using Android;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace EditTextRatingBar
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var editText = FindViewById<Button>(Resource.Id.editText1);

            editText.Click += EditText_Click;
        }


        private void EditText_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Thanks for Submmiting", ToastLength.Short).Show();
        }
    }
}