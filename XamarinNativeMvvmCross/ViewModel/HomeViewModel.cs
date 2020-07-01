using System;
using System.Threading.Tasks;
using MvvmCross.ViewModels;

namespace XamarinNativeMvvmCross.ViewModel
{
    public class HomeViewModel : MvxViewModel
    {
        public HomeViewModel()
        {
        }

        public override void Prepare()
        {
            
            // This is the first method to be called after construction
        }

        public override Task Initialize()
        {
            // Async initialization, YEY!

            return base.Initialize();

        }

    }
}
