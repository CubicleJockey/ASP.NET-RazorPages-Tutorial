﻿using FluentAssertions;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RazorPagesMovie.EF;
using RazorPagesMovie.Pages.Movie;

namespace RazorPagesMovie.Tests.Pages.Movie
{
    [TestClass]
    public class BasePageContextTests
    {
        private readonly MockBasePageContext fakeBasePageContext;

        public BasePageContextTests()
        {
            fakeBasePageContext = new MockBasePageContext();
        }

        [TestMethod]
        public void InheritsFromPageModel()
        {
            fakeBasePageContext.Should().BeAssignableTo<PageModel>();
        }

        [TestMethod]
        public void ContextIsNotNull()
        {
            fakeBasePageContext.IsContextSet.Should().BeTrue();
        }

        private class MockBasePageContext : BasePageContext
        {
            public MockBasePageContext() 
                : base(new RazorPagesMovieContext(new DbContextOptions<RazorPagesMovieContext>())) { }

            public bool IsContextSet => Context != null;
        }
    }
}
