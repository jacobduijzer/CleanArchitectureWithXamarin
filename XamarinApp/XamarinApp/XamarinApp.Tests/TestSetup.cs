using System;
using MvvmCross.IoC;
using MvvmCross.Tests;

namespace XamarinApp.Tests
{
    public class TestSetup : MvxIoCSupportingTest
    {
        public TestSetup()
        {
            base.Setup();
        }

        protected override void AdditionalSetup()
        {
            base.AdditionalSetup();
        }

        protected override IMvxIocOptions CreateIocOptions()
        {
            return new MvxIocOptions()
            {
                PropertyInjectorOptions = MvxPropertyInjectorOptions.All
            };
        }
    }
}
