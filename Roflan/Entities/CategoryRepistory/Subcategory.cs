using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Roflan.Entities.CategoryRepistory
{
    public class Subcategory
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength:255)]
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }


        //public int CategoryId { get; set; }
        //public Category Category { get; set; }
        //[ForeignKey("Category")]
        //public int CategoryId { get; set; }
    }
}