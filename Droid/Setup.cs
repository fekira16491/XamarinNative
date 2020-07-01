using System;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;

namespace XamarinNativeMvvmCross.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        public Setup()
        {
        }


        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
