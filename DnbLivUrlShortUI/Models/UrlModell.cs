﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnbLivUrlShortUI.Models
{
    public class UrlModell
    {
        [Required]
        public string LongURL { get; set; } 

        public string ShortURL { get; set; }
    }
}