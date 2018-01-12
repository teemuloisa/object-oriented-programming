using System;

namespace task_book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Kirja 1", "Kirjailija 1", 123, 10);
            Book book2 = new Book("Kirja 2", "Kirjailija 2", 124, 15);

            Console.WriteLine($"Vertailu: {book1.CompareBook(book2)}");

            Console.ReadKey();




        }

     
    }
}
