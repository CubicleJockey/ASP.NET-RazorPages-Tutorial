using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.Constants;

namespace RazorPagesMovie.Tests.Constants
{
    [TestClass]
    public class EnvironmentsTests
    {
        [TestMethod]
        [Description("Development property must not be any other string value.")]
        public void DevelopmentIsValid()
        {
            Environments.Development.Should().Be("Development");
        }

        [TestMethod]
        [Description("Test property must not be any other string value.")]
        public void TestIsValid()
        {
            Environments.Test.Should().Be("Test");
        }

        [TestMethod]
        [Description("Production property must not be any other value.")]
        public void ProductionIsValid()
        {
            Environments.Production.Should().Be("Production");
        }
    }
}
