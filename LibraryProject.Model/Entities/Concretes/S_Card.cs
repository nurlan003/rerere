using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class S_Card : BaseEntity
    {
        public int StudentId { get; set; }
        public int BooksId { get; set; }
        public DateTime DateOut { get; set; }
        public DateTime DateIn { get; set; }
        public int LibId { get; set; }
    }
}
