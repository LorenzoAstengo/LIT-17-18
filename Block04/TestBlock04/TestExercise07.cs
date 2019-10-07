using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise07;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise07
    {
        Library library = new Library("Mondadori");
        Book book = new Book("Zio Tobia", "Beppe", "Mondadori", "22/11/1996", "978-35-223-589-12");
        Book book2 = new Book("ABCD", "Stephen King", "Mondadori", "1/1/1980", "978-35-223-589-13");
        Book book3 = new Book("Tempesta", "Stephen King", "Zanichelli", "15/12/1986", "978-35-223-589-14");
        Book book4 = new Book("Zio Tobia2", "Beppe", "Mondadori", "22/11/2000", "978-35-223-589-15");
        Book book5 = new Book("Zio Tobia3", "Beppe", "Mondadori", "22/11/2010", "978-35-223-589-16");

        [TestMethod]
        public void TestResearchAndDeletionAndRemainigInfo()
        {            
            library.AddBook(book);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);

            var res = library.SearchByAuthor("Stephen King");
            foreach(Book a in res)
            {
                library.DeleteBook(a);
            }
            Assert.AreEqual(3, library.BookList.Count);

            foreach (Book a in library.BookList)
            {
                string[] info = library.BookInfo(a);
                Assert.AreEqual(a.Title, info[0]);
                Assert.AreEqual(a.Author, info[1]);
                Assert.AreEqual(a.Publisher, info[2]);
                Assert.AreEqual(a.ReleaseDate, info[3]);
                Assert.AreEqual(a.IsbnCode, info[4]);
            }            
        }

        [TestMethod]
        public void TestBookInfo()
        {
            foreach (Book a in library.BookList)
            {
                string[] info = library.BookInfo(a);
                Assert.AreEqual(a.Title, info[0]);
                Assert.AreEqual(a.Author, info[1]);
                Assert.AreEqual(a.Publisher, info[2]);
                Assert.AreEqual(a.ReleaseDate, info[3]);
                Assert.AreEqual(a.IsbnCode, info[4]);
            }
        }    
    }
}

