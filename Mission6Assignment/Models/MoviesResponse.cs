﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6Assignment.Models
{
    // Contains the model class for adding a movie and parameters.
    public class MoviesResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

    }
}
