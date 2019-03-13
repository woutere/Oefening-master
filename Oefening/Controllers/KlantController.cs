using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Oefening.Models;

namespace Oefening.Controllers
{
    public class KlantController : Controller
    {
        public IActionResult Index()
        {
            //Get list of klanten
            List<Klant> vKlanten = new List<Klant>();

            vKlanten.Add(new Klant() { ID = 1, Naam = "De Neve", Voornaam = "Jos", AangemaaktDatum = new System.DateTime(2019, 1, 20) });
            vKlanten.Add(new Klant() { ID = 2, Naam = "Bruynseels", Voornaam = "Rita", AangemaaktDatum = new System.DateTime(2019, 2, 4) });
            vKlanten.Add(new Klant() { ID = 3, Naam = "Naert", Voornaam = "Willy", AangemaaktDatum = new System.DateTime(2018,12,29) });

            return View(vKlanten);
        }
    }
}