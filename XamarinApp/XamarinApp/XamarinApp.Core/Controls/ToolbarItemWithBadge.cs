using Xamarin.Forms;
using XamarinApp.Core.Helpers.Extensions;
using XamarinApp.Core.Interfaces;

namespace XamarinApp.Core.Controls
{
    public class ToolbarItemWithBadge : ToolbarItem
    {
        public static readonly BindableProperty BadgeCountProperty = BindableProperty.Create(
            nameof(BadgeCount),
            typeof(int),
            typeof(ToolbarItemWithBadge), 
            defaultValue: 0,
            propertyChanged: OnBadgeCountChanged);

        public int BadgeCount
        {
            get { return (int)GetValue(BadgeCountProperty); }
            set { SetValue(BadgeCountProperty, value); }
        }

        static void OnBadgeCountChanged(BindableObject bindable, object oldVal, object newVal)
        {
            if(int.TryParse(newVal.ToString(), out int newValue))
            {
                var element = ((ToolbarItemWithBadge)bindable);

                if (newValue > 0)
                {
                    var page = element.GetParentPage();
                    DependencyService.Get<IToolbarItemBadgeService>().SetBadge(page, element, $"{newValue}", Color.Red, Color.White);
                }
            }
        }
    }
}
