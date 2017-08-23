using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBookIssueSystem
{
    public interface IBook
    {
        string Genre { get; }
        string Author { get; }
        string Title { get; }
        float Price { get; }
    }
}
