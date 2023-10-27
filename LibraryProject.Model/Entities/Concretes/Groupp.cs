using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Groupp : BaseEntity
    {
        public string Name { get; set; }
        public int FacultyId { get; set; }
    }
}
