using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookCataloguer
{
    class Book
    {

        private string title;
        public string Title { get { return title; } }

        private string author;
        public string Author { get { return author; } }

        private string genre;
        public string Genre { get { return genre; } }

        public Book()
        {

        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public Book(string title, string author, string genre)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
        }
    }
}
