using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.Constants;

namespace RazorPagesMovie.Tests.Constants
{
    [TestClass]
    public class ViewBagKeysTests
    {
        [TestMethod]
        public void TitleKeyIsValid()
        {
            ViewDataKeys.Title.Should().Be("Title");
        }
    }
}
