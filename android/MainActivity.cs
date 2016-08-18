using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace android
{
    [Activity(Label = "android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Text = "page1";
            button.Click += delegate { MoveToSecondPage(); };



            LinearLayout MainTable = FindViewById<LinearLayout>(Resource.Id.linearLayoutM);
            Button b;
            //add back button
            b = new Button(this);
            b.Text = "ActionBarPage";
            b.Click += delegate {
                MoveToActionBarPage();
            };
            
            MainTable.AddView(b);

            //add back button
            b = new Button(this);
            b.Text = "ActionBarPageWithBar";
            b.Click += delegate {
                MoveToActionBarPage2();
            };
            
            MainTable.AddView(b);

            //add back button
            b = new Button(this);
            b.Text = "AlertBar";
            b.Click += delegate {
                MoveToWaitBarPage();
            };

            MainTable.AddView(b);
        }


        private void MoveToSecondPage()
        {
            Intent deviceList = new Intent(this, typeof(SecondPage));

            Bundle bundle = new Bundle();　　//　　Bundle的底层是一个HashMap<String, Object
            bundle.PutString("index", "HI this a string From page1");
            deviceList.PutExtra("bundle", bundle);

            StartActivity(deviceList);
        }

        private void MoveToActionBarPage()
        {
            Intent deviceList = new Intent(this, typeof(ActionBarPage));            

            StartActivity(deviceList);
        }
        private void MoveToActionBarPage2()
        {
            Intent deviceList = new Intent(this, typeof(ActionBarPageWithBar));

            StartActivity(deviceList);
        }
        private void MoveToWaitBarPage()
        {
            Intent deviceList = new Intent(this, typeof(WaitBarPage));

            StartActivity(deviceList);
        }
    }
}

