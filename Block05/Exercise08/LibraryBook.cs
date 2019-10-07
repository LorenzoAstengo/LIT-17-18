// File: LibraryBook.cs
// This file creates a concrete LibraryBook class that adds
// an author to the LibraryItem data.
// LibraryBook IS-A LibraryItem

using System;

namespace Library
{
    public class LibraryBook : LibraryItem
    {
        public const decimal DAILYLATEFEE = 0.25m; // Book's daily late fee
                                                   // Precondition: theCopyrightYear >= 0 and theLoanPeriod >= 0
                                                   // Postcondition: The library book has been initialized with the specified
                                                   // values for title, publisher, copyright year, loan period,
                                                   // call number, and author. The item is not checked out.
        public LibraryBook(String theTitle, String thePublisher, int theCopyrightYear,
            int theLoanPeriod, String theCallNumber, String theAuthor) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Author = theAuthor;
        }
        public string Author
        {
            // Precondition: None
            // Postcondition: The author has been returned
            get;
            // Precondition: None
            // Postcondition: The author has been set to the specified value
            set;
        }
        // Precondition: daysLate >= 0
        // Postcondition: The fee for returning the item the specified days late
        // has been returned
        public override decimal CalcLateFee(int daysLate)
        {
            if (daysLate >= 0)
                return daysLate * DAILYLATEFEE;
            else
                throw new ArgumentOutOfRangeException("daysLate",
                daysLate, "daysLate must be >= 0");
        }
        // Precondition: None
        // Postcondition: A string is returned presenting the libary item's data on
        // separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = String.Format("LibraryBook{2}Author:\t\t{0}{2}{1}",
                Author, base.ToString(), System.Environment.NewLine);
            return result;
        }
    }
}
