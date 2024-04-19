﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp6
{
    public class Zamestnanec
    {
        public Zamestnanec(int id, string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
        }

        public int? Id { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }
        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {DatumNarozeni.ToShortDateString()}";
        }
    }
}
