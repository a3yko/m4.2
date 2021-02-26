using System;
using System.Collections.Generic;
using System.Text;

namespace BookCase
{
    class Book
    {
        private string title;
        private string author;
        private double price;
        private string isbn;


        public Book(string title, string author, double price, string isbn)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isbn = isbn;
        }

        public double getPrice()
        {
            return this.price;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public string getTitle()
        {
            return this.title;
        }
        public string getIsbn()
        {
            return this.isbn;
        }

        public void setPrice(double price)
        {
            this.price = price;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public void setIsbn(string isbn)
        {
            this.isbn = isbn;
        }

        public string printInformation()
        {
            return this.title + " written by " + this.author + " is " + this.price + ", with ISBN:" + this.isbn;
        }
 
    }
}
