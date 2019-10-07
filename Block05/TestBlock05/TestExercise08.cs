using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Library;
using System.Linq;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise08
    {
        static List<LibraryItem> items;
        static List<LibraryPatron> patrons;

        [ClassInitialize]
        public static void InitializeClass(TestContext context)
        {
            items = new List<LibraryItem>();
            patrons = new List<LibraryPatron>();

            LibraryItem b1 = new LibraryBook("Multithreading with C# Cookbook - Second Edition",
                "Packt Publishing", 2016, 14, "ZZ25 3G", "Eugene Agafonov");
            LibraryItem b2 = new LibraryBook("Agile Software Development: Principles, Patterns, and " +
                "Practices", "Prentice Hall", 2002, 14, "ZZ27 3G", "Robert Cecil Martin ");
            LibraryItem m1 = new LibraryMovie("The Lord of the Rings: The Fellowship of the Ring",
                "New Line Cinema", 2002, 7, "MM33 2D", 178, "Peter Jackson",
                LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryItem m2 = new LibraryMovie("Star Wars", "LucasFilm", 1977, 7, "MM35 3D", 97.5,
                "George Lucas", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryItem t1 = new LibraryMusic("Ten", "Epic", 1991, 14, "CD44 4Z", 53.2,
                "Pearl Jam", LibraryMediaItem.MediaType.CD, 11);
            LibraryItem t2 = new LibraryMusic("Born to Run", "columbia", 1975, 14,
                "CD46 4Z", 39.26, "Bruce Springsteen", LibraryMediaItem.MediaType.CD, 8);
            LibraryItem j1 = new LibraryJournal("IEEE Transactions on Pattern Analysis and Machine Intelligence",
                "IEEE", 2011, 14, "JJ12 7M", 1, 2, "Bioengineering Computing & Processing", "David A. Forsyth");
            LibraryItem j2 = new LibraryJournal("IEEE Transactions on Image Processing",
                "IEEE", 2011, 14, "JJ15 7M", 1, 2, "Image Processing", "Scott Acton");
            LibraryItem z1 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA53 9A", 16, 9);
            LibraryItem z2 = new LibraryMagazine("C# Monthly", "Unige Mags", 2010, 14, "MA57 9A", 19, 12);

            LibraryPatron p1 = new LibraryPatron("Gino", "12345");
            LibraryPatron p2 = new LibraryPatron("Pino", "12365");
            LibraryPatron p3 = new LibraryPatron("Chiara", "12325");
            LibraryPatron p4 = new LibraryPatron("Serse", "12315");
            LibraryPatron p5 = new LibraryPatron("Mia", "12395");
            items.Add(b1);
            items.Add(b2);
            items.Add(m1);
            items.Add(m2);
            items.Add(t1);
            items.Add(t2);
            items.Add(j1);
            items.Add(j2);
            items.Add(z1);
            items.Add(z2);
            patrons.Add(p1);
            patrons.Add(p2);
            patrons.Add(p3);
            patrons.Add(p4);
            patrons.Add(p5);
        }

        [TestInitialize]
        public void Initialize()
        {
            items[0].CheckOut(patrons[0]);
            items[2].CheckOut(patrons[1]);
            items[4].CheckOut(patrons[2]);
            items[6].CheckOut(patrons[3]);
            items[8].CheckOut(patrons[4]);
        }

        [TestMethod]
        public void TestCheckedOut()
        {
            var checkedOut =
                from i in items
                where i.IsCheckedOut() == true
                select i;
            Assert.AreEqual(5, checkedOut.Count());
        }

        [TestMethod]
        public void TestMediaCheckedOut()
        {
            var mediaCkecked =
                from i in items
                where i.IsCheckedOut() == true &&
                (i.CallNumber.StartsWith("C") || i.CallNumber.StartsWith("MM"))
                select i;
            Assert.AreEqual(2, mediaCkecked.Count());
        }

        [TestMethod]
        public void TestSelectMagazineTitles()
        {
            var megazineTitles =
                from m in items
                where m.CallNumber.StartsWith("MA")
                group m by new { m.Title }
                into titles
                select titles.FirstOrDefault();
            
            Assert.AreEqual(1, megazineTitles.Count());
            Assert.AreEqual("C# Monthly", megazineTitles.ElementAt(0).Title);
        }

        [TestMethod]
        public void TestCalculateFees()
        {
            List<decimal> fees = new List<decimal>();
            foreach (var i in items)
                fees.Add(i.CalcLateFee(14));

            Assert.AreEqual(3.5m, fees[0]);
            Assert.AreEqual(21m, fees[2]);
            Assert.AreEqual(7m, fees[4]);
            Assert.AreEqual(10.5m, fees[6]);
            Assert.AreEqual(3.5m, fees[8]);
        }

        [TestMethod]
        public void TestSelectBookTitleAndPeriod()
        {
            var libraryBook =
                from l in items
                where l.CallNumber.StartsWith("ZZ")
                select new { l.Title, l.LoanPeriod };
            Assert.AreEqual(2, libraryBook.Count());
            Assert.AreEqual("Multithreading with C# Cookbook - Second Edition", libraryBook.ElementAt(0).Title);
            Assert.AreEqual("Agile Software Development: Principles, Patterns, and Practices", libraryBook.ElementAt(1).Title);
            Assert.AreEqual(14, libraryBook.ElementAt(0).LoanPeriod);
            Assert.AreEqual(14, libraryBook.ElementAt(1).LoanPeriod);
        }

        [TestMethod]
        public void TestAddDaysToBooks()
        {
            foreach (var item in items)
            {
                if (item.CallNumber.StartsWith("ZZ"))
                {
                    item.LoanPeriod += 7;
                    
                }
            }
            var libraryBook =
                from l in items
                where l.CallNumber.StartsWith("ZZ")
                select new { l.Title, l.LoanPeriod };

            Assert.AreEqual(2, libraryBook.Count());
            Assert.AreEqual("Multithreading with C# Cookbook - Second Edition", libraryBook.ElementAt(0).Title);
            Assert.AreEqual("Agile Software Development: Principles, Patterns, and Practices", libraryBook.ElementAt(1).Title);
            Assert.AreEqual(21, libraryBook.ElementAt(0).LoanPeriod);
            Assert.AreEqual(21, libraryBook.ElementAt(1).LoanPeriod);
        }
    }
}
