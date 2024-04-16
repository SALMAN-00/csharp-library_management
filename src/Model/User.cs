using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class User : BaseEntity
    {
        public string Name { get; set; }

        public User(string name, DateTime? createdDate = null) : base(createdDate)
        {
            Name = name;
        }
    }
}