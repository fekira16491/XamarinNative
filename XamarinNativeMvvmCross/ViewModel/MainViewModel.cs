using System;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace XamarinNativeMvvmCross.ViewModel
{
    public class MainViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;


        public MainViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;

        }

        public override void Prepare()
        {
            WelcomeText = "Welcome to Xamarin";
            // This is the first method to be called after construction
        }

        public override Task Initialize()
        {
            // Async initialization, YEY!

            return base.Initialize();

        }

        public IMvxCommand ResetTextCommand => new MvxCommand(ResetText);

        private void ResetText()
        {
            WelcomeText = "Hello MvvmCross";
        }

        private string _text = "Hello MvvmCross";
        public string WelcomeText
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private ICommand _homeCommand;
        public ICommand HomeCommand
        {
            get
            {
                _homeCommand = _homeCommand ?? new MvxCommand(DoSubmit);
                return _homeCommand;
            }
        }

        private async void DoSubmit()
        {
            await _navigationService.Navigate<HomeViewModel>();

        }
    }
}
