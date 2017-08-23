using System;
using Xunit;
using System.Collections.Generic;

namespace LibraryBookIssueSystem
{
    public class LibraryFixture
    {
        ScifiBook somescifibook = new ScifiBook("Interesting Title", "Famous Author", 350);
        ScifiBook anotherscifibook = new ScifiBook("Interesting Title", "Famous Author", 350);

        [Fact]
        public void library_Constructor_should_set_available_books()
        {
            List<IBook> listofbooks = new List<IBook>();
            listofbooks.Add(somescifibook);
            listofbooks.Add(anotherscifibook);
            Library library = new Library(listofbooks);
            Assert.Equal(library.BooksAvailable, listofbooks);
        }
        [Fact]
        public void library_Constructor_should_set_available_and_lended_books()
        {
            List<IBook> listoflendedbooks = new List<IBook>();
            List<IBook> listofavailablebooks = new List<IBook>();
            listofavailablebooks.Add(somescifibook);
            listoflendedbooks.Add(anotherscifibook);
            Library library = new Library(listofavailablebooks,listoflendedbooks);
            Assert.Equal(library.BooksLended, listoflendedbooks);
        }
        [Fact]
        public void showAllAvailableBooks_Test()
        {
            List<IBook> listofbooks = new List<IBook>();
            listofbooks.Add(somescifibook);
            listofbooks.Add(anotherscifibook);
            Library library = new Library(listofbooks);
            Assert.Equal(library.ShowAllAvailableBooks(), somescifibook.ToString() + "\n\n" + anotherscifibook.ToString() + "\n\n");
        }
        [Fact]
        public void showAllLendedBooks_Test()
        {
            List<IBook> listoflendedbooks = new List<IBook>();
            List<IBook> listofavailablebooks = new List<IBook>();
            listofavailablebooks.Add(somescifibook);
            listoflendedbooks.Add(anotherscifibook);
            Library library = new Library(listoflendedbooks);
            Assert.Equal(library.ShowAllLendedBooks(), anotherscifibook.ToString() + "\n\n");
        }
    }
}

