using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign03oop
{
    internal class Book
    {
        internal string? Title { get; set; }
        internal string? Author {  get; set; }
        internal string? ISBN {  get; set; }

        public Book (string title , string author ,string iSBN )
        {  
            Title = title; 
            Author = author; 
            ISBN = iSBN; 
        }

        public override string ToString()
        {
            return $"Title : {Title} \nAuthor : {Author} \nISBN : {ISBN}";
        }
    }
}
