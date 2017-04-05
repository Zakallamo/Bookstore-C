using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_C
{
    interface IBook
    {
        string Title { get; }
        string Author { get; }
        decimal Price { get; }
        int Quantity { get; }
    }
}
