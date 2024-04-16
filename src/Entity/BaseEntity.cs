using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library
{
    public class BaseEntity
    {
        public Guid id;
        public DateTime createdDate;
        public BaseEntity(DateTime? date = null)
        {
            id = Guid.NewGuid();
            createdDate = (DateTime)(date == null ? DateTime.Now : date);

        }

    }
}
