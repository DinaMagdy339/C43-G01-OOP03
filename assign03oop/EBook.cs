using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign03oop
{
    internal class EBook : Book
    {
        public double FullSize {  get; set; }
        public EBook(string? title , string? author , string? isbn , double fullSize) : base (title , author ,isbn)
        {
            FullSize = fullSize;
        }
        public override string ToString()
        {
            Console.WriteLine( base.ToString() ) ;
            return $"FullSize = {FullSize}";
        }
    }
}
