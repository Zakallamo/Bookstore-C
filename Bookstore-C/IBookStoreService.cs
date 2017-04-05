using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_C
{
    interface IBookStoreService
    {
        Task<IEnumerable<IBook>> GetBooksAsync(string searchString);
    }
}