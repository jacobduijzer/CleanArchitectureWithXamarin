using Xamarin.Forms;

namespace XamarinApp.Core.Interfaces
{
    public interface IToolbarItemBadgeService
    {
        void SetBadge(Page page, ToolbarItem item, string value,Color backgroundColor, Color textColor);
    } 
}
