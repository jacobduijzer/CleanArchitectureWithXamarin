using MvvmCross;
using MvvmCross.Platforms.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinApp.Core.Interfaces;
using XamarinApp.Droid.Helpers;

[assembly: Dependency(typeof(ToolbarItemBadgeService))]
namespace XamarinApp.Droid.Helpers
{
    public class ToolbarItemBadgeService : IToolbarItemBadgeService
    {
        public void SetBadge(Page page, ToolbarItem item, string value, Color backgroundColor, Color textColor)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var currentActivity = Mvx.IoCProvider.Resolve<IMvxAndroidCurrentTopActivity>()?.Activity;
                var toolbar = currentActivity.FindViewById(Resource.Id.toolbar) as Android.Support.V7.Widget.Toolbar;

                if (toolbar != null)
                {
                    if (!string.IsNullOrEmpty(value))
                    {
                        var idx = page.ToolbarItems.IndexOf(item);
                        if (toolbar.Menu.Size() > idx)
                        {
                            var menuItem = toolbar.Menu.GetItem(idx);
                            BadgeDrawable.SetBadgeText(currentActivity, menuItem, value, backgroundColor.ToAndroid(), textColor.ToAndroid());
                        }
                    }
                }
            });
        }
    }
}
