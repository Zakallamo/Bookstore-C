using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore_C
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

        List<Book> books, cart;

        public StoreLogic()
        {
            books = new List<Book>();
            cart = new List<Book>();
        }

        // Update cart with information and send said information to client
        void UpdateCart()
        {
            decimal value = CartValue();
            NotifyCustomer("Cart Updated.");
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
        public void PlaceOrder()
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
            Messages = message;
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

            NotifyCustomer("No book was removed.");
        }

        // Add book to cart
        public void AddToCart(List<Book> tempBook)
        {
            for (int i = 0; i < tempBook.Count; i++)
            {
                cart.Add(tempBook[i]);
            }

            NotifyCustomer("Book added.");
            return;
        }

        public string Messages
        {
            get { return message; }
            set { message = value; }
        }

        // IBook part
        public string Title
        {
            get { return titleName; }
            set { titleName = value; }
        }
        public string Author
        {
            get { return authorName; }
            set { authorName = value; }
        }
        public decimal Price
        {
            get { return bookPrice; }
            set { bookPrice = value; }
        }
        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        // IBookStoreService part
        public Task<IEnumerable<IBook>> GetBooksAsync(string searchString)
        {
            string[] tempString = searchString.Split(',');
            DummyFileloader loader = new DummyFileloader();
            List<Book> tempBookList = new List<Book>();
            Book book = new Book();

            List<string> temp = loader.Loader();

            for (int i = 0; i < temp.Count(); i++ )
            {
                if (temp[i] == "title")
                {
                    book.title = temp[i + 1];
                }
                else if (temp[i] == "author")
                {
                    book.author = temp[i + 1];
                }
                else if (temp[i] == "price")
                {
                    book.price = decimal.Parse(temp[i + 1], System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture);
                }
                else if (temp[i] == "inStock")
                {
                    book.qty = int.Parse(temp[i+1]);
                    books.Add(book);
                }
            }
            
            foreach (var item in books)
            {
                if ((item.title.Equals(tempString[0]) && item.author.Equals(tempString[1])) || (item.title.Equals(tempString[1]) && item.author.Equals(tempString[0])))
                {
                    tempBookList.Add(item);
                }
            }
            return null;
            //return tempBookList;
        }
    }
}