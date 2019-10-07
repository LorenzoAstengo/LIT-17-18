// File: LibraryPatron.cs
// This file creates a simple LibraryPatron class capable of tracking
// the patron's name and ID.

using System;

namespace Library
{
    public class LibraryPatron
    {
        private String patronName; // Name of the patron
        private String patronID; // ID of the patron
                                 // Precondition: None
                                 // Postcondition: The patron has been initialized with the specified name
                                 // and ID
        public LibraryPatron(String name, String id)
        {
            PatronName = name;
            PatronID = id;
        }
        public String PatronName
        {
            // Precondition: None
            // Postcondition: The patron's name has been returned
            get
            {
                return patronName;
            }
            // Precondition: None
            // Postcondition: The patron's name has been set to the specified value
            set
            {
                patronName = value;
            }
        }
        public String PatronID
        {
            // Precondition: None
            // Postcondition: The patron's ID has been returned
            get
            {
                return patronID;
            }
            // Precondition: None
            // Postcondition: The patron's ID has been set to the specified value
            set
            {
                patronID = value;
            }
        }
        // Precondition: None
        // Postcondition: A string is returned presenting the library patron's data on
        // separate lines
        public override string ToString()
        {
            return String.Format("Name:\t\t{0}{2}ID:\t\t{1}",
            PatronName, PatronID, System.Environment.NewLine);
        }
    }
}
