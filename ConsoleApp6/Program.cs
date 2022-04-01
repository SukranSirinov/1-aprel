using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book()
            {
                Name = "Art ve Xaos",
                AuthorName = "Qaraqan",
                PageCount = 400

            };
            Book book2 = new Book()
            {
                Name = "Birinci Addim",
                AuthorName = "Qaraqan",
                PageCount = 350

            };
            Book book3 = new Book()
            {
                Name = "Ikinci addim",
                AuthorName = "Qaraqan",
                PageCount = 270

            };
            Library libraries = new Library();
           libraries.Books.Add(book1);
            libraries.Books.Add(book2);
            libraries.Books.Add(book3);

            Console.WriteLine("Kitablarin siyahisi");
            foreach (Book book in libraries.Books)
            {
                Console.WriteLine($"BookName-{book.Name} BookPageCount-{book.PageCount} BookAuthorName-{book.AuthorName}  ");

            }
            Console.WriteLine("Sehife sayina gore filtir");
            foreach (Book book in libraries.FindAllBooksByPageCountRange(150,400))
            {
                Console.WriteLine($"BookName-{book.Name} BookPageCount-{book.PageCount} BookAuthorName-{book.AuthorName}  ");
            }
            Console.WriteLine("Kitab adina gore axtaris");
            foreach (Book book in libraries.FindAllBooksByName("addim"))
            {
                Console.WriteLine($"BookName-{book.Name} BookPageCount-{book.PageCount} BookAuthorName-{book.AuthorName}  ");
            }
        }
    }
}
