using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Models.Entities.Concretes
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public int Pages { get; set; }
        public int YearPress { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
        public int ThemesId { get; set; }
        public int PressId { get; set; }
        public string? Comment  { get; set; }
        public int Quantity  { get; set; }



        public virtual Author IdAuthorsNavigation { get; set; } = null!;
        public virtual Category IdCategoryNavigation { get; set; } = null!;


    }
}
