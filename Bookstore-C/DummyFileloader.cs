using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Text.RegularExpressions;

namespace Bookstore_C
{
    class DummyFileloader
    {
        // Just a dummy file loader
        public List<string> Loader()
        {
            WebClient fileloader = new WebClient();
            List<string> temp = new List<string>();
            string[] temporaryString = Regex.Split(fileloader.DownloadString("http://www.contribe.se/arbetsprov-net/books.json"), @"[\"",:}]");

            for (int i = 0; i < temporaryString.Count(); i++)
            {
                // Cleaning up the input from file to a readable list
                if (temporaryString[i] == "books" || temporaryString[i] == "{" || temporaryString[i] == "}" || temporaryString[i] == "[\n\t{" || temporaryString[i] == "\n\t{" || temporaryString[i] == "\n]" || temporaryString[i] == "" || temporaryString[i] == " " || temporaryString[i] == " [\n\t{")
                {
                    // And yes, this does nothing.
                }
                else
                {
                    temp.Add(temporaryString[i]);
                }
            }

            return temp;
        }
    }
}