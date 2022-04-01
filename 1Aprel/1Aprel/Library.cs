using System;
using System.Collections.Generic;
using System.Text;

namespace _1Aprel
{
    internal class Library
    {
        public List<Book> books = new List<Book>();
        
        public List<Book> FindAllBooksByName(string name)
        {
            List<Book> filteredBooks = new List<Book>();
            
            foreach (var item in books)
            {
                 
                if (item.Name.Contains(name))
                {
                    filteredBooks.Add(item);
                }
            }
            return filteredBooks;
        }

        public void RemoveAllBookByName(string val)
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Name == val)
                {
                    books.RemoveAt(i);
                }
            }
        }
        public List<Book> SearchBooks(string val)
        {
            List<Book> filteredBook = new List<Book>();

            foreach (var item in books)
            {
                if (item.Name.Contains(val) || item.AuthorName.Contains(val))
                {
                    filteredBook.Add(item);
                }
            }
            return filteredBook;
        }
        public List<Book> FindAllBooksByPageCountRange(int min , int max)
        {
            List<Book> filteredBook = new List<Book> ();

            foreach (var item in books)
            {
                if (item.PageCount > min && item.PageCount <max)
                {
                    filteredBook.Add(item);
                }
            }
            return filteredBook;
        }
        public void RemoveByCode(int? No)
        {
            if (No == null)
            {
                throw new ArgumentNullException("Deyer null ola bilmez");
            }
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].No == No )
                {
                    books.RemoveAt(i);
                }
            }
        }
    }
}
