using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    interface IBookStoreService
    {
        Task<IEnumerable<IBook>> GetBooksAsync(string searchString);
        
        string Message { get; set; }

        List<Book> Books { get; set; }
        List<Book> Cart { get; set; }
        Book addToCart { get; set; }
        Book removeFromCart { get; set; }

        void Checkout();
        void RemoveFromCart(Book book);
        void AddToCart(Book book);
        void Messages();
    }
}