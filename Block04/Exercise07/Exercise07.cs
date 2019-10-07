using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        private string publisher;
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }
        private string releaseDate;
        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        private string isbnCode;
        public string IsbnCode
        {
            get { return isbnCode; }
            set { isbnCode = value; }
        }

        public Book(string title, string author, string publisher, string releaseDate, string isbnCode)
        {
            this.title = title;
            this.author = author;
            this.publisher = publisher;
            this.releaseDate = releaseDate;
            this.isbnCode = isbnCode;
        }
    }

    public class Library
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Book> bookList = new List<Book>();
        public List<Book> BookList
        {
            get { return bookList; }
            set { bookList = value; }
        }

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(Book book)
        {
            bookList.Add(book);
        }

        public List<Book> SearchByAuthor(string author)
        {
            List<Book> list = bookList.FindAll(x => x.Author == author);
            return list;        
        }

        public string[] BookInfo(Book book)
        {
            string[] info = new string[5];
            info[0] = book.Title;
            info[1] = book.Author;
            info[2] = book.Publisher;
            info[3] = book.ReleaseDate;
            info[4] = book.IsbnCode;
            return info;
        }

        public void DeleteBook(Book book)
        {
            bookList.Remove(book);
        }
    }
}
