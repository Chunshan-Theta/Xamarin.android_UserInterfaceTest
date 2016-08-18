using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.View;
using Android.Support.V4.App;
using Android.Content.PM;
using ActionBarViewPage;

namespace android
{
    [Activity(Label = "android")]
    public class ActionBarPageWithBar : FragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);


            // Get our button from the layout resource,
            // and attach an event to it
            SetContentView(Resource.Layout.ActionBarPage);
            var pager = FindViewById<ViewPager>(Resource.Id.pager);
            var adaptor = new GenericFragmentPagerAdaptor(SupportFragmentManager);




            adaptor.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                var sampleTextView = view.FindViewById<TextView>(Resource.Id.textView1);
                sampleTextView.Text = "This is content";
                return view;
            }
            );

            adaptor.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                var sampleTextView = view.FindViewById<TextView>(Resource.Id.textView1);
                sampleTextView.Text = "This is more content";
                return view;
            }
            );
            adaptor.AddFragmentView((i, v, b) =>
            {
                var view = i.Inflate(Resource.Layout.tab, v, false);
                var sampleTextView = view.FindViewById<TextView>(Resource.Id.textView1);
                sampleTextView.Text = "This is more' content";
                return view;
            }
            );
            pager.Adapter = adaptor;

            //add leaderbar
            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
            pager.AddOnPageChangeListener(new ViewPageListenerForActionBar(ActionBar));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Tab1"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Tab2"));
            ActionBar.AddTab(pager.GetViewPageTab(ActionBar, "Tab3"));




        }

    }
}

