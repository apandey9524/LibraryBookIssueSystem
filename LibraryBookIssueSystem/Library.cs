using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookIssueSystem
{
    public class Library
    {
        public Library(List<IBook> listofavailablebooks)
        {
            BooksAvailable = listofavailablebooks;
            BooksLended = new List<IBook>();
        }
        public Library(List<IBook> listofavailablebooks,List<IBook> listoflendedbooks)
        {
            BooksAvailable = listofavailablebooks;
            BooksLended = listoflendedbooks;
        }

        public List<IBook> BooksAvailable { get; private set; }
        public List<IBook> BooksLended { get; private set; }
        public string ShowAllBooks()
        {
            return ShowAllAvailableBooks() + ShowAllLendedBooks();
        }
        public string ShowAllAvailableBooks()
        {
            string result=string.Empty;
            foreach (var book in BooksAvailable)
            {
                result +=book.ToString()+"\n\n";
            }
            return result;
        }

        public string ShowAllLendedBooks()
        {
            string result = string.Empty;
            foreach (var book in BooksLended)
            {
                result += book.ToString() + "\n\n";
            }
            return result;
        }
        //TODO:should also contain a filestream property to add log of issue &return
    }
}
