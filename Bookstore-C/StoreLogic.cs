using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    struct Book
    {
        public string title, author;
        public decimal price;
        public int qty;
    }

    class StoreLogic : IBook, IBookStoreService
    {
        private string titleName, authorName, message;
        private decimal bookPrice;
        private int qty;
        private Book specificBook, removeSpecificBook;
        private List<Book> tempBookList = new List<Book>();

        List<Book> books = new List<Book>();
        List<Book> cart = new List<Book>();
        StoreLogic store = new StoreLogic();

        // Add Title, author and all stats to "Book" and then put it in a list of books
        Book addBook()
        {
            Book book = new Book();

            book.title = store.Title;
            book.author = store.Author;
            book.price = store.Price;
            book.qty = store.Quantity;

            return book;
        }

        // Update cart with information and send said information to client
        void UpdateCart()
        {
            decimal value = CartValue();
            NotifyCustomer("Cart Updated");
        }

        // Calculate cart
        decimal CartValue()
        {
            decimal cartPrice = 0;

            foreach (var book in cart)
            {
                cartPrice =+ book.price * book.qty;
            }
            return cartPrice;
        }

        // Place order and compare if wanted quantity and actual quantity is allowed
        void PlaceOrder()
        {
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].qty > books[i].qty)
                {
                    RemoveFromCart(cart[i]);
                }

                NotifyCustomer("This is bought: " + cart[i].title + ", " + cart[i].author);
            }

            NotifyCustomer("At a total price of: " + CartValue());
        }

        // notify customer about what is ordered and what failed to be ordered because of not enough books in storage.
        void NotifyCustomer(string message)
        {
            store.Message = message;
        }

        // IBook part
        public string Title
        {
            get { return titleName; }
        }
        public string Author
        {
            get { return authorName; }
        }
        public decimal Price
        {
            get { return bookPrice; }
        }
        public int Quantity
        {
            get { return qty; }
        }

        // IBookStoreService part
        public Task<IEnumerable<IBook>> GetBooksAsync(string searchString)
        {
            string[] tempString = searchString.Split(',');

            // I have never worked with "Task" or "IEnumerable" before so I don't know how to use it. I clearly need practical examples on just that.
            // Had I known how to use IEnumerable as an iterator then this would have looked differently. I'm writing this just to show my thought process behind this.

            /*do
            {
                books.Add(addBook());
            } while (true);*/

            foreach (var book in books)
            {
                if ((book.title.Equals(tempString[0]) && book.author.Equals(tempString[1])) || (book.title.Equals(tempString[1]) && book.author.Equals(tempString[0])))
                {
                    Books.Add(book);
                }
            }
            return null;
        }

        public void Checkout()
        {
            PlaceOrder();
            return;
        }

        // Remove books from cart
        public void RemoveFromCart(Book tempBook)
        {
            foreach (var book in cart)
            {
                if (book.Equals(tempBook))
                {
                    cart.Remove(book);
                    NotifyCustomer("Book Removed");
                    UpdateCart();
                    return;
                }
            }

            NotifyCustomer("No book was removed");
        }

        // Add book to cart
        public void AddToCart(Book book)
        {
            cart.Add(book);
            NotifyCustomer("Book added");
            return;
        }

        public void Messages()
        {
            return;
        }

        // Message to the client
        public string Message
        {
            get { return message; }
            set { message = value; }
        }

        // If there is multiple books that matches the searchstring, send it to have the customer choose
        public List<Book> Books
        {
            get { return tempBookList; }
            set { tempBookList = value; }
        }

        // Send what is currently in the cart to the client.
        public List<Book> Cart
        {
            get { return null; }
            set { cart = value; }
        }

        // Add the chosen book to cart and wanted quantity
        public Book addToCart
        {
            get { return specificBook; }
            set { }
        }

        public Book removeFromCart
        {
            get { return removeSpecificBook; }
            set { }
        }
    }
}