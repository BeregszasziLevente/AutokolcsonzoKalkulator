
List<double> vegossz = new List<double>();

for (int i = 0; i < 4; i++)
{
    Console.WriteLine($"\n{i + 1}. bérlés adatai: ");

    Console.Write("\tBérlő neve: ");
    string nev=Console.ReadLine();
    
    Console.Write("\tKölcsönzött napok száma: ");
    int napok = int.Parse(Console.ReadLine());
    
    Console.Write("\tVIP tag-e? (igen/nem): ");
    string vipIn=Console.ReadLine();
    
    bool vip;
    if (vipIn == "igen")
    {
        vip = true;
    }
    else vip = false;

    int alapertek = 12000 * napok;

    double kedvezmeny;
    
    if (napok >= 7 || vip == true) { kedvezmeny = 0.85; }
    else if (napok >= 3) { kedvezmeny = 0.95; }
    else kedvezmeny = 1;

    double vegosszeg = kedvezmeny * (double)alapertek;
    vegossz.Add(vegosszeg);
}

Console.WriteLine("\nRögzített kölcsönzések adatai: ");

for (int i =0; i < vegossz.LongCount(); i++)
{
    Console.WriteLine($"\t- {i + 1}. bérlés: {vegossz[i]} Ft");
}

double teljesBevetel = 0.0;

for (int i = 0; i<vegossz.LongCount(); i++)
{
    teljesBevetel += vegossz[i];
}

double atlag = teljesBevetel/vegossz.LongCount();

string ertekeles;

if (teljesBevetel >= 200000) ertekeles = "Kiemelkedő forgalmú nap!";
else if (teljesBevetel >= 100000) ertekeles = "Átlagos forgalmú nap.";
else ertekeles = "Gyenge forgalmú nap.";

Console.WriteLine($"\nNapi teljes bevétel: {Math.Round(teljesBevetel,0)} Ft");
Console.WriteLine($"Átlagos kölcsönzési díj: {Math.Round(atlag,0)} Ft");
Console.WriteLine($"Napi értékelés: {ertekeles}");