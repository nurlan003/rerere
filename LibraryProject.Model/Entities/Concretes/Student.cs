using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }        
        public string LastName { get; set; }
        public int GroupId { get; set; }
        public int term { get; set; }

    }
}
