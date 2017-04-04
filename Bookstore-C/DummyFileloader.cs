using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace BookStore
{
    class DummyFileloader
    {
        public string Loader()
        {
            WebClient fileloader = new WebClient();
            string books = fileloader.DownloadString("http://www.contribe.se/arbetsprov-net/books.json");

            return books;
        }
    }
}