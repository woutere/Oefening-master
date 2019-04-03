﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Oefening.Models
{
    public class Bestelling
    {
        public int BestellingID { get; set; }
        public string Artikel { get; set; }
        public Decimal? Prijs { get; set; }
        public int KlantID { get; set; }
        public Klant Klant { get; set; }
    }
}
