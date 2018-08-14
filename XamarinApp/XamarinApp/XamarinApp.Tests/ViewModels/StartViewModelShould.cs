using System;
using Xunit;
using XamarinApp.Core.ViewModels;
using FluentAssertions;

namespace XamarinApp.Tests.ViewModels
{
    public class StartViewModelShould : TestSetup
    {
        public StartViewModelShould()
        {
        }

        [Fact(Skip = "TODO: Fix")]
        public void Construct()
        {
            var vm = Ioc.IoCConstruct<StartViewModel>();
            vm.Should().BeOfType<StartViewModel>();
        }
    }
}
