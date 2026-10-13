using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.Models
{
    public class KopoAlkatresz : Alkatresz
    {
        public int CserePeriodusKm { get; set; }
        public KopoAlkatresz(string nev, int ar, string AutoTipus, int csereperiodus) : base(nev, ar, AutoTipus)
        {
            CserePeriodusKm = csereperiodus;
        }

        public override void Kiiras()
        {
            Console.WriteLine($"Kopó alkatrész: {Nev}, Ár: {Ar}, Autó típus: {AutoTipus}, Csere: {CserePeriodusKm} km után");
        }
    }
}
