﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarStock.Models
{
    public class SearchModel
    {
        [Required]
        public string SearchTerm { get; set; }

        [Required]
        public string SearchProperty { get; set; }
    }
}
