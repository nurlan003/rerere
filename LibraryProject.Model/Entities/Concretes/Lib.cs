using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Lib : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
