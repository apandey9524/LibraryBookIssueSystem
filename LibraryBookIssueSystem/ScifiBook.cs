using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookIssueSystem
{
    public class ScifiBook:IBook
    {
        public ScifiBook(string title,string author,float price)
        {
            Genre = "Scifi";
            Title = title;
            Author = author;
            Price = price;
        }

        public string Genre { get; private set; }

        public string Author { get; private set; }

        public string Title { get; private set; }

        public float Price { get; private set; }

        public override string ToString()
        {
            return $"Title:{Title}\nAuthor:{Author}\nGenre:{Genre}\nPrice:{Price}";
        }
    }
}
