﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoBooks.Models
{
    public class Book
    {        
        public int BookID { get; set; }

        [Required]
        public string Title { get; set; }

        public int Year { get; set; }

        [Range(1, 500)]
        public decimal Price { get; set; }

        public string Genre { get; set; }
                
        [Required]
        [Display(Name = "Author")]
        public int AuthorID { get; set; }

        public virtual Author Author { get; set; }
    }
}
