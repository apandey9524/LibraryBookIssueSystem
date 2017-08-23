using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookIssueSystem
{
    public class Librarian
    {
        public Library CurrentLibrary { get;private set;}//the librarian can be used to handle multiple libraries
        public Librarian(Library library)
        {
            CurrentLibrary = library;
        }
        public bool IssueFromLibrary(IBorrower borrower,IBook booktobeissued,out Reciept reciept)
        {
            if (CurrentLibrary.BooksAvailable.Contains(booktobeissued))
            {
                CurrentLibrary.BooksAvailable.Remove(booktobeissued);
                CurrentLibrary.BooksLended.Add(booktobeissued);
                reciept = new Reciept(borrower, DateTime.Now, booktobeissued);
                return true;
            }
            else
            {
                reciept = null;
                return false;
            }
        }

    }
}
