using System;

namespace LibraryBookIssueSystem
{
    public class Reciept
    {
        public Reciept(IBorrower borrower,DateTime dateofissue,IBook book)
        {
            Borrower = borrower;
            DateOfIssue = dateofissue;
            Book = book;
        }
        public IBorrower Borrower { get; private set; }
        public DateTime DateOfIssue{ get; private set; }
    public IBook Book{ get; private set; }
    }
}