using System;

namespace _1Aprel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book()
            {
                Name = "Seymur",
                PageCount = 10,
                AuthorName ="Seymur"
            };
            Book book2 = new Book()
            {
                Name = "Seymur1",
                PageCount = 1,
                AuthorName = "Seymur"
            };
            Book book1 = new Book()
            {
                Name = "Ferid1",
                PageCount = 5,
                AuthorName = "Seymur"
                
            };
            Library library = new Library();
            library.books.Add(book);
            library.books.Add(book1);
            library.books.Add(book2);
            //library.RemoveAllBookByName("Seymur1");
            //foreach (var item in library.books)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in library.FindAllBooksByPageCountRange(0,6))
            //{
            //    Console.WriteLine(item.Name);
            //}
            //library.RemoveByCode(1);
            //foreach (var item in library.books)
            //{
            //    Console.WriteLine(item.Name);
            //}
            //foreach (var item in library.SearchBooks("1"))
            //{
            //    Console.WriteLine(item.Name);
            //}



        }
    }
}
