using System;
using System.Collections.Generic;
using System.Text;

namespace GarageManager.Models
{
    public class KarosszeriaElem : Alkatresz
    {
        public string Szin { get; set; }

        public KarosszeriaElem(string nev, int ar, string AutoTipus, string szin) : base(nev, ar, AutoTipus)
        {
            Szin = szin;
        }
        public override void Kiiras()
        {
            Console.WriteLine($"Karosszéria elem: {Nev}, Ár: {Ar}, Autó típus: {AutoTipus}, Szín: {Szin}");
        }
    }
}
