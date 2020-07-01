using System;
using Android.App;
using Android.OS;
using MvvmCross.Droid.Support.V7.AppCompat;
using XamarinNativeMvvmCross.ViewModel;

namespace XamarinNativeMvvmCross.Droid.Activity
{
    [Activity(Label = "XamarinNativeMvvmCross",Theme = "@style/Theme.AppCompat.Light", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainViewActivity : MvxAppCompatActivity<MainViewModel>
    {
        public MainViewActivity()
        {
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
        }
    }
}
