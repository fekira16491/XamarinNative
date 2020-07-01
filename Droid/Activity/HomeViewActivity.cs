
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
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinNativeMvvmCross.ViewModel;

namespace XamarinNativeMvvmCross.Droid.Activity
{
    [Activity(Label = "HomeViewActivity",Theme = "@style/Theme.AppCompat.Light", Icon = "@mipmap/icon")]
    public class HomeViewActivity : MvxAppCompatActivity<HomeViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Home);

            // Create your application here
        }
    }
}
