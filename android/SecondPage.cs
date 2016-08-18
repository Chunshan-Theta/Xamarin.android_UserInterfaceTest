using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;


namespace android
{
    [Activity(Label = "android")]
    public class SecondPage : FragmentActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            //get Data
            //    得到跳转到该Activity的Intent对象
            Bundle bundle = Intent.GetBundleExtra("bundle");
            string index = bundle.GetString("index");


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Text = "page2";
            button.Click += delegate { button.Text = string.Format("{0} clicks!"+ index, count++); };



            //add back button
            Button b =  new Button(this);
            b.Text = "go back to page1";
            b.Click += delegate {
                this.Finish();
            };
            LinearLayout MainTable = FindViewById<LinearLayout>(Resource.Id.linearLayoutM);
            MainTable.AddView(b);

        }

    }
}

