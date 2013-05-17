using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookCataloguer
{
    public partial class Form1 : Form
    {
        List<Book> bookList = new List<Book>();
        string listOfBooks = "";
        string title = "Title: ";
        string author = "Author: ";
        string genre = "Genre: ";
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void addBook_Click(object sender, EventArgs e)
        {
            if (genreBox.Text == "")
            {
                Book book = new Book(titleBox.Text, authorBox.Text);
                addNewBook(book);
            }
            else
            {
                Book book = new Book(titleBox.Text, authorBox.Text, genreBox.Text);
                addNewBook(book);
            }
        }

        private void listBooks_Click(object sender, EventArgs e)
        {
            genListOfBooks();
            listBox.Text = listOfBooks;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            genListOfBooks();
            listBox.Text = listOfBooks;
            saveBookList();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            listBox.Clear();
            bookList.Clear();
            
            listOfBooks = "";
            int counter = 0;
            string listTitle="";
            string listAuthor="";
            string listGenre="";

            System.IO.StreamReader file = new System.IO.StreamReader("list.txt");

            while ((listOfBooks = file.ReadLine()) != null)
            {

                if (listOfBooks.StartsWith(title))
                {
                   listTitle = listOfBooks.Substring(title.Length, listOfBooks.Length - title.Length);
                }
                if (listOfBooks.StartsWith(author))
                {
                   listAuthor = listOfBooks.Substring(author.Length, listOfBooks.Length - author.Length);
                }
                if (listOfBooks.StartsWith(genre))
                {
                   listGenre = listOfBooks.Substring(genre.Length, listOfBooks.Length - genre.Length);
                }

                counter++;

                if (counter == 3)
                {
                    bookBuilder(listTitle, listAuthor, listGenre);
                    counter = 0;
                }

            }

            genListOfBooks();
            listBox.Text = listOfBooks;
            file.Close();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            listBox.Text = "";
            int randNum = random.Next(0, bookList.Count);
            
            Book randBook = bookList[randNum];
            listBox.Text = "Your random book is: " + randBook.Title + "\r\nBy: " + randBook.Author;
            
            bookList.Remove(randBook);
            genListOfBooks();
            saveBookList();
        }

        private void clearBoxes()
        {
            titleBox.Text = "";
            authorBox.Text = "";
            genreBox.Text = "";
        }

        private void addNewBook(Book book)
        {
            bookList.Add(book);
            clearBoxes();
            titleBox.Focus();
        }

        private void genListOfBooks()
        {
            listOfBooks = "";
            foreach (Book book in bookList)
            {
                listOfBooks += title + book.Title + "\r\n" + author + book.Author + "\r\n" + genre + book.Genre + "\r\n";
            }
        }

        private void bookBuilder(string listTitle, string listAuthor, string listGenre)
        {
            Book book = new Book(listTitle, listAuthor, listGenre);
            addNewBook(book);
        }

        private void saveBookList()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("list.txt");
            file.WriteLine(listOfBooks);
            file.Close();
        }
    }
}
