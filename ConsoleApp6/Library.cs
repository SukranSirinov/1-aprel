using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Library
    {
       public List<Book> Books = new List<Book>();
        

        public List<Book> FindAllBooksByName(string value)
        {
            List<Book> newBooks = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                   newBooks.Add(book);
            }
            return newBooks;
        }
        public List<Book> FindAllBooksByPageCountRange(int Min,int Max)
        {
            List<Book>NewBook=new List<Book>();
            foreach (Book book in Books)
            {
                if(book.PageCount>Min && book.PageCount < Max)
                {
                    NewBook.Add(book);
                }
                
            }
            return NewBook;
        }
        public void RemoveAllBookByName(string value)
        {
            foreach (Book book in Books)
            {
                if (book.Name.Contains(value))
                    Books.Remove(book);


            }
            
        }
        public void RemoveByCode(int val)
        {
            foreach (Book book in Books)
            {
                if (book.No == val)
                {
                    Books.Remove(book);
                }


            }
            

        }
        public List<Book> SearchBooks(string val)
        {
            List<Book> NewBooks=new List<Book>();
            foreach (Book book in Books)
            {
                string text = book.Name + book.AuthorName + book.PageCount;
                if (text.Contains(val))
                {
                    NewBooks.Add(book);
                }

            }
            return NewBooks;    
        }
    }
}
