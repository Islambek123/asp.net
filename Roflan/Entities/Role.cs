﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Roflan.Entities
{
    public class Role 
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Name { get; set; }
    }
}