using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using AndroidHUD;
using System.Threading.Tasks;

namespace android
{
    [Activity(Label = "android")]
    public class WaitBarPage : FragmentActivity
    {

        protected override  void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.WaitBar);

            //Show a simple status message with an indeterminate spinner and a Clear background
            //AndHUD.Shared.Show(this, "Status Message", Convert.ToInt32(MaskType.Clear));

            //Show a progress with a filling circle representing the progress amount, showing 60% full
            //AndHUD.Shared.Show(this, "Loading… 60%", maskType: MaskType.Black);
            //AndHUD.Shared.Show(this, "Loading… 60%");

            //Show a success image with a message, with a Clear background, and auto-dismiss after 2 seconds
            //AndHUD.Shared.ShowSuccess(this, "It Worked!", MaskType.Clear, TimeSpan.FromSeconds(2));

            //Show an error image with a message with a Dimmed background, and auto-dismiss after 2 seconds
            //AndHUD.Shared.ShowError(this, "It no worked :(", MaskType.Black, TimeSpan.FromSeconds(2));

            //Show a toast, similar to Android toasts, but styled as AndHUD, with a clear background, auto-dismiss after 2 seconds
            //AndHUD.Shared.ShowToast(this, "This is a non-centered Toast…", MaskType.Clear, TimeSpan.FromSeconds(2));


            //Show a custom image with text
            //AndHUD.Shared.ShowImage(this, Resource.Drawable.Icon, "Custom");

            //Dismiss a HUD that will or will not be automatically timed out
            //await Task.Delay(1000); AndHUD.Shared.Dismiss(this);


            //Show a HUD and only close it when it's clicked
            //AndHUD.Shared.ShowToast(this, "Click this toast to close it!", MaskType.Clear, null, true, () => AndHUD.Shared.Dismiss(this));

            LinearLayout MainTable = FindViewById<LinearLayout>(Resource.Id.linearLayoutM);
            Button b;
            //add back button
            b = new Button(this);
            b.Text = "ShowToast";
            b.Click += delegate {
                ShowToast();
            };
            MainTable.AddView(b);

            b = new Button(this);
            b.Text = "ShowImage";
            b.Click += delegate {
                ShowImage();
            };
            MainTable.AddView(b);

            b = new Button(this);
            b.Text = "Showsuccess";
            b.Click += delegate {
                Showsuccess();
            };
            MainTable.AddView(b);


            b = new Button(this);
            b.Text = "ShowError";
            b.Click += delegate {
                ShowError();
            };
            MainTable.AddView(b);

            b = new Button(this);
            b.Text = "ShowLoading";
            b.Click += delegate {
                ShowLoading();
            };
            MainTable.AddView(b);

        }
        private void ShowToast()
        {
            //Show a toast, similar to Android toasts, but styled as AndHUD, with a clear background, auto-dismiss after 2 seconds
            AndHUD.Shared.ShowToast(this, "This is a non-centered Toast…", MaskType.Clear, TimeSpan.FromSeconds(2));
        }
        private async void ShowImage()
        {
            //Show a custom image with text
            AndHUD.Shared.ShowImage(this, Resource.Drawable.Icon, "Custom");

            //Dismiss a HUD that will or will not be automatically timed out
            await Task.Delay(1000); AndHUD.Shared.Dismiss(this);
        }
        private async void ShowLoading()
        {
            //Show a progress with a filling circle representing the progress amount, showing 60% full
            AndHUD.Shared.Show(this, "Loading… ", maskType: MaskType.Black);
            
            //Dismiss a HUD that will or will not be automatically timed out
            await Task.Delay(1000); AndHUD.Shared.Dismiss(this);
        }
        private void Showsuccess()
        {
            //Show a success image with a message, with a Clear background, and auto-dismiss after 2 seconds
            AndHUD.Shared.ShowSuccess(this, "It Worked!", MaskType.Clear, TimeSpan.FromSeconds(2));
        }
        private  void ShowError()
        {
            //Show an error image with a message with a Dimmed background, and auto-dismiss after 2 seconds
            AndHUD.Shared.ShowError(this, "It no worked :(", MaskType.Black, TimeSpan.FromSeconds(2));

        }


    }
    }

