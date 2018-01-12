using System;
using System.Collections.Generic;
using System.Text;

namespace task_book
{
    class Book
    {
        public string Title;
        public string Author;
        public int Id;
        public int Price;

        public Book(string title, string author, int id, int price)
        {
            Title = title;
            Author = author;
            Id = id;
            Price = price;

            
        }

        public string CompareBook(Book book)
        {
            
            if (this.Price > book.Price)
                return( $"{this.Title} on kalliimpi kuin {book.Title} kirja");
            else
                return ($"{book.Title} on kalliimpi kuin {this.Title} kirja");
        }

       
    }
}
