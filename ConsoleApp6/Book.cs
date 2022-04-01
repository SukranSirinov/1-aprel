using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    internal class Book
    {
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int No { get; }
        private static int _no;
        public int PageCount { get; set; }
        public Book()
        {
            _no++;
            this.No=_no;
        }
    }
}
