
List<int> vegossz = new List<int>();

for (int i = 0; i < 4; i++)
{
    Console.Write("Bérlő neve: ");
    string nev=Console.ReadLine();
    
    Console.Write("Kölcsönzött napok száma: ");
    int napok = int.Parse(Console.ReadLine());
    
    Console.Write("VIP tag-e? (igen/nem): ");
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

    int vegosszeg = (int)kedvezmeny * alapertek;
    vegossz.Add(vegosszeg);
}

int teljesBevetel = 0;

for (int i = 0; i<vegossz.LongCount(); i++)
{
    teljesBevetel += vegossz[i];
}

double atlag = teljesBevetel/vegossz.LongCount();

string ertekeles;

if (teljesBevetel >= 200000) ertekeles = "Kiemelkedő forgalmú nap!";
else if (teljesBevetel >= 100000) ertekeles = "Átlagos forgalmú nap.";
else ertekeles = "Gyenge forgalmú nap";

