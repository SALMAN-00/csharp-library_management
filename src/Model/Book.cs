using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using library;

namespace library
{
    public class Book : BaseEntity
    {
        public string Title { get; set; }
 
        public Book(string title, DateTime? createdDate = null) : base(createdDate)
        {

            Title = title;
        }

    }
}