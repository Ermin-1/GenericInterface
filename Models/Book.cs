using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface.Models
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Author Author { get; set; }
    }
}
