﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESBX_MyPLC.Models
{
    public class NarudzbeVM
    {
        public int KorisnikId { get; set; }

        public int SalataId { get; set; }

        public int KorpaId { get; set; }

        public string Cijena { get; set; }

        public string Kolicina { get; set; }

        public string Sastojci { get; set; }

        public bool Komentirana { get; set; }

    }
}
