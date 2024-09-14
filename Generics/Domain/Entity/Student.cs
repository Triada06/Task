using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class Student : BaseEntity
    {
        public string Fullname { get; set; }
        public int Age { get; set; }
    }
}
