using MvvmCross.Localization;
using MvvmCross.ViewModels;
using MediatR;
using MvvmCross;

namespace XamarinApp.Core.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        protected readonly IMediator Mediator;

        public BaseViewModel()
        {
            Mediator = Mvx.IoCProvider.Resolve<IMediator>();
        }

        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public IMvxLanguageBinder TextSource
        {
            get { return new MvxLanguageBinder(GetType().Assembly.GetName().Name, GetType().Name); }
        }
    }
}

