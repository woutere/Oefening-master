﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Oefening.Models
{
    public class Klant
    {
        public int ID { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        [DataType(DataType.Date)]
        public DateTime AangemaaktDatum { get; set; }
    }
}
