using System;
using XamarinApp.Core.Interfaces;

namespace XamarinApp.Core.Helpers.AppSettings
{
    public class DebugSettings : ISettings
    {
        #region CrashReporting

        public string CrashReporting_iOS_Key => throw new NotImplementedException();

        public string CrashReporting_Android_Key => throw new NotImplementedException();

        #endregion
    }
}
