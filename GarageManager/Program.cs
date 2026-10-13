using GarageManager.Interfaces;
using GarageManager.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Alkatresz> raktar = new List<Alkatresz>();
        List<Alkatresz> rendelesek = new List<Alkatresz>();
        raktar.Add(new KopoAlkatresz("Olajszűrő", 15000, "Toyota Corolla", 10000));
        raktar.Add(new KarosszeriaElem("Lökhárító", 20000, "Toyota Corolla", "Fehér"));
        raktar.Add(new KopoAlkatresz("Levegőszűrő", 12000, "Honda Civic", 15000));
        raktar.Add(new KarosszeriaElem("Bal első ajtó", 25000, "Honda Civic", "Fekete"));
        raktar.Add(new KopoAlkatresz("Fékbetét", 20000, "Suzuki Swift", 40000));
        rendelesek.Add(new KopoAlkatresz("Olajszűrő", 15000, "Mercedes E-Class", 10000));
        rendelesek.Add(new KarosszeriaElem("Jobb hátsó ajtó", 30000, "BMW 3 Series", "Kék"));


        bool fut = true;
        while (fut)
        {
            Console.WriteLine("--Raktár menü--");
            Console.WriteLine("1. Alkatrészek listázása");
            Console.WriteLine("2. Alkatrész hozzáadása");
            Console.WriteLine("3. Alkatrész keresése neve alapján");
            Console.WriteLine("4. Alkatrész keresése autó márkája alapján");
            Console.WriteLine("5. Rendelések listázása");
            Console.WriteLine("6. Kilépés");
            Console.Write("Válassz egy opciót: ");
            string valasztas = Console.ReadLine();
            switch (valasztas)
            {
                case "1":
                    foreach (var alkatresz in raktar)
                    {
                        alkatresz.Kiiras();
                    }
                    break;

                case "2":
                    Console.Write("Add meg az alkatrész típusát (1: Kopóalkatrész, 2: Karosszériaelem): ");
                    string tipus = Console.ReadLine();
                    Console.Write("Add meg az alkatrész nevét: ");
                    string nev = Console.ReadLine();
                    Console.Write("Add meg az alkatrész árát: ");
                    int ar = int.Parse(Console.ReadLine());
                    Console.Write("Add meg az autó típusát: ");
                    string autoTipus = Console.ReadLine();
                    if (tipus == "1")
                    {
                        Console.Write("Add meg a csere periódust kilométerben: ");
                        int cserePeriodusKm = int.Parse(Console.ReadLine());
                        raktar.Add(new KopoAlkatresz(nev, ar, autoTipus, cserePeriodusKm));
                    }
                    else if (tipus == "2")
                    {
                        Console.Write("Add meg az alkatrész színét: ");
                        string szin = Console.ReadLine();
                        raktar.Add(new KarosszeriaElem(nev, ar, autoTipus, szin));
                    }
                    else
                    {
                        Console.WriteLine("Érvénytelen típus.");
                    }
                    break;

                case "3":
                    Console.Write("Add meg a keresett alkatrész nevét: ");
                    string keresettNev = Console.ReadLine();
                    bool talalat = false;
                    foreach (var alkatresz in raktar)
                    {
                        if (alkatresz.Nev.Contains(keresettNev))
                        {
                            alkatresz.Kiiras();
                            talalat = true;
                        }
                    }
                    if (!talalat)
                    {
                        Console.WriteLine("Nincs ilyen nevű alkatrész a raktárban, szeretnéd megrendelni? (i/n)");
                        string valasz = Console.ReadLine().ToLower();
                        if (valasz == "i")
                        {
                            var alkatreszneve = keresettNev;
                            Console.Write("Add meg az alkatrész árát: ");
                            int ara = int.Parse(Console.ReadLine());
                            Console.Write("Add meg az autó típusát: ");
                            string autoTipusa = Console.ReadLine();
                            Console.Write("Kérlek add meg az alkatrész típusát (1: Kopóalkatrész, 2: Karosszériaelem): ");
                            string atipus = Console.ReadLine();
                            if(atipus == "1")
                            {
                                Console.Write("Add meg a csere periódust kilométerben: ");
                                int cserePeriodusKm = int.Parse(Console.ReadLine());
                                rendelesek.Add(new KopoAlkatresz(alkatreszneve, ara, autoTipusa, cserePeriodusKm));
                            }
                            else if (atipus == "2")
                            {
                                Console.Write("Add meg az alkatrész színét: ");
                                string szin = Console.ReadLine();
                                rendelesek.Add(new KarosszeriaElem(alkatreszneve, ara, autoTipusa, szin));
                            }
                            else
                            {
                                Console.WriteLine("Érvénytelen típus.");
                            }


                        }
                        else if (valasz == "n")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Érvénytelen válasz.");
                        }
                    }
                    break;

                case "4":
                    Console.Write("Add meg a keresett autó márkáját: ");
                    string keresettAuto = Console.ReadLine();
                    bool talalatAuto = false;
                    foreach (var alkatresz in raktar)
                    {
                        if (alkatresz.AutoTipus.Contains(keresettAuto))
                        {
                            alkatresz.Kiiras();
                            talalatAuto = true;
                        }
                    }
                    if (!talalatAuto)
                    {
                        Console.WriteLine("Nincs ilyen típusú alkatrész a raktárban.");
                    }
                    break;

                case "5":
                    Console.WriteLine("--Rendelések--");
                    foreach (var rendeles in rendelesek)
                    {
                        rendeles.Kiiras();
                    }
                    break;

                case "6":
                    fut = false;
                    break;
            }
        }
    }
}