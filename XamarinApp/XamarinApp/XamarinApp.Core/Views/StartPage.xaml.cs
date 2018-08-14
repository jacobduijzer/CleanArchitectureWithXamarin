using MvvmCross.Forms.Views;
using XamarinApp.Core.ViewModels;
using Xamarin.Forms.Xaml;

namespace XamarinApp.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : MvxContentPage<StartViewModel>
    {
        public StartPage()
        {
            InitializeComponent();
        }
    }
}
