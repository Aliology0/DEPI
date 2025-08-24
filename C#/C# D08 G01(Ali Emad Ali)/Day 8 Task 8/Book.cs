using System;

namespace Day_8_Task_8
{
    public class Book
    {
        private string title;
        private string author;

        #region Constructors
        // Default Constructor
        public Book() : this("Unknown Title", "Unknown Author") { }

        // Title Constructor
        public Book(string _title) : this(_title, "Unknown Author") { }

        // General Constructor
        public Book(string _title, string _author)
        {
            title = _title;
            author = _author;
        }
        #endregion

        public override string ToString()
        {
            return $"Title: {title}, Author: {author}";
        }
    }
}