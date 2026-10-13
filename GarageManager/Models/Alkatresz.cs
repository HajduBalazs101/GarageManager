using GarageManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.Models
{
    public abstract class Alkatresz : IAlkatresz
    {
        public string Nev { get; set; }
        public int Ar { get; set; }
        public string AutoTipus { get; set; }
    
        public Alkatresz(string nev, int ar, string autoTipus)
        {
            Nev = nev;
            Ar = ar;
            AutoTipus = autoTipus;
        }
        public abstract void Kiiras();

    }
}
