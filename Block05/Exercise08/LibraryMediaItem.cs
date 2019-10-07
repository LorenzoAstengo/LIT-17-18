// File: LibraryMediaItem.cs
// This file creates an abstract LibraryMediaItem class that adds
// media type and duration.
// LibraryMediaItem IS-A LibraryItem

using System;

namespace Library
{
    public abstract class LibraryMediaItem : LibraryItem
    {
        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }; // Possible media types

        // String names of media types - Must put in same order as items in MediaType enum
        private String[] MediaTypeNames = { "DVD", "Blu-Ray", "VHS", "CD", "SACD", "VINYL" };
        private double itemDuration; // The item's duration (in minutes)
                                     // Precondition: theCopyrightYear >= 0 and theLoanPeriod >= 0 and
                                     // theDuration >= 0
                                     // Postcondition: The library media item has been initialized with the specified
                                     // values for title, publisher, copyright year, loan period,
                                     // call number, and duration. The item is not checked out.
        public LibraryMediaItem(String theTitle, String thePublisher, int theCopyrightYear,
        int theLoanPeriod, String theCallNumber, double theDuration) :
            base(theTitle, thePublisher, theCopyrightYear, theLoanPeriod, theCallNumber)
        {
            Duration = theDuration;
        }
        // Abstract property header
        public abstract MediaType Medium
        {
            // Precondition: None
            // Postcondition: The medium has been returned
            get;
            // Precondition: Varies - See concrete implementation
            // Postcondition: The medium has been set to the specified value
            set;
        }
        public double Duration
        {
            // Precondition: None
            // Postcondition: The duration has been returned
            get
            {
                return itemDuration;
            }
            // Precondition: value >= 0
            // Postcondition: The duration has been set to the specified value
            set
            {
                if (value >= 0)
                    itemDuration = value;
                else
                    throw new ArgumentOutOfRangeException("ItemDuration",
                        value, "ItemDuration must be >= 0");
            }
        }
        // Precondition: None
        // Postcondition: A string is returned presenting the libary item's data on
        // separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = String.Format("Duration:\t{0:F1}{1}",
                Duration, System.Environment.NewLine);
            result += String.Format("Medium:\t\t{0}{2}{1}",
                MediaTypeNames[(int)Medium], base.ToString(),
                System.Environment.NewLine);
            return result;
        }
    }
}
