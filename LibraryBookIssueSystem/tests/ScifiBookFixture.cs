using System;
using System.Collections.Generic;
using Xunit;

namespace LibraryBookIssueSystem
{
    public class ScifiBookFixture
    {
        [Fact]
        public void tostringtest()
        {
            ScifiBook somescifibook = new ScifiBook("Interesting Title", "Famous Author", 350);
            Assert.Equal(somescifibook.ToString(), "Title:Interesting Title\nAuthor:Famous Author\nGenre:Scifi\nPrice:350");
        }
    }
}
