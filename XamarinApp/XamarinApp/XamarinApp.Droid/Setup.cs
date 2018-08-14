using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.IoC;

namespace XamarinApp.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.CoreApp, Core.FormsApp>
    {
        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions()
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.MvxInject
            };
        }
    }
}
