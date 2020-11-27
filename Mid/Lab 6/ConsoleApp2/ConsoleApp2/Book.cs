using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Book
    {
        private string bookName;
        private string bookAuthor;
        private string bookId;
        private string bookType;
        private int bookCopy;

        public string BookName
        {
            get { return bookName; }
            set { bookName = value; }
        }
        public string BookAuthor
        {
            get { return bookAuthor; }
            set { bookAuthor = value; }
        }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string BookType
        {
            get { return bookType; }
            set { bookType = value; }
        }
        public int BookCopy
        {
            get { return bookCopy; }
            set { bookCopy = value; }
        }

        public Book()
        {
            bookName = "Himu";
            bookAuthor = "Humayon Ahmed";
            bookId = "101";
            bookType = "Nobel";
            bookCopy = 100;
        }
        public Book(string bookName, string bookAuthor, string bookId, string bookType, int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void AddBookCopy(int x)
        {
            bookCopy += x;
        }
    }
}
