﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roflan.Entities.CategoryRepistory
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(maximumLength:255)]
        public string Name { get; set; }

        public virtual ICollection<Subcategory> Subcategory { get; set; }
        //public ICollection<Subcategory> Subcategory { get; set; }
        //public virtual Subcategory Subcategory { get; set; }
    }
}