﻿using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlazbeniOglasnik.Helpers
{
    public class PrijavljeniKorisnik
    {
        public static Korisnik prijavljeniKorisnik = new Korisnik();

        public void PrijaviKorisnika(Korisnik korisnik)
        {
            prijavljeniKorisnik = korisnik;
        }

        public Korisnik DohvatiPrijavljenogKorisnika()
        {
            return prijavljeniKorisnik;
        }
    }
}
