using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGyakorlo
{
    class npcs
    {
        static Random veletlen_jutalom = new Random();
        static int jutalom = veletlen_jutalom.Next(1, 5);
        static string tárgy = "";
        public string kuldetes_jutalom_aladin()
        {
            if(jutalom == 1)
            {
                Console.WriteLine("A jutalmad a következő lenne: Krokodkil bőr, értéke: 5 arany");
                string tárgy = "Krokodil bőr";
            }
            if(jutalom == 2)
            {
                Console.WriteLine("A jutalmad a következő lenne: Arany kard, értéke: 50 arany");
                string tárgy = "Arany kard";
            }
            if(jutalom == 3)
            {
                Console.WriteLine("A jutalmad a következő lenne: 5 darab répa, értéke: 0,5 arany");
                string tárgy = "5 darab répa";
            }
            if(jutalom == 4)
            {
                Console.WriteLine("A jutalmad a következő lenne: Arany tojás, értéke: 120 arany");
                string tárgy = "1 arany tojás";
            }
            return tárgy;
        }
        public string párbeszéd_aladin()
        {
            string name = "Aladin";
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Üdv utazó az én nevem "+name+" azzal szeretnélek megbízni, hogy legyőzöd a következő szőrnyet: Mocsár krokodil");
                Console.WriteLine("Rengeteg gondott okoz a falunak, és megszeretnének tőle szabadulni.");
                Console.WriteLine("Ajánlott kard-sebzés: 177~213 ");
                Console.WriteLine("Ajánlott védelem: 150");
                Console.WriteLine("Nehézségi fokozatt: Normál");
            }     
            return name;
        }
        public string párbeszéd_Szenyor()
        {
            string name = "Szenyor.Profi";
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Az elöző küldetés után találkozol egy öltönyös öregemberrel..");
                Console.WriteLine("Mizus van utazó, az egyik társammal problémák vannak és nem hajlandó fizetni, az én nevem: "+name);
                Console.WriteLine("A hapsi lenyúlt 2000 aranyat egy szó nélkül, hozzd vissza nekem, és megtarthatod az 5%-át!");
                Console.WriteLine("Ajánlott kard sebzés: 59~95");
                Console.WriteLine("Ajánlott védelem: 185");
                Console.WriteLine("Nehézségi fokozat: Könnyű");
            }
            return name;
        }
        public string jutalom_Szenyor()
        {
            if(jutalom == 1)
            {
                Console.WriteLine("1. A jutalmad a következő lenne: 1. Nike csuka kínaiból, értéke: 10 arany");
                Console.WriteLine("2. Bónusz 100 arany");
                string tárgy = "Nike csuka";
            }
            if(jutalom == 2)
            {
                Console.WriteLine("1. A jutalmad a következő lenne: Gfuel[GamerFuel] 1kg, értéke: 30 arany");
                Console.WriteLine("2. Bónusz 100 arany");
                string tárgy = "Gfuel";
            }
            if(jutalom == 3)
            {
                Console.WriteLine("1. A jutalmad a következő lenne: Piros nyakkendő, értéke: 2 arany");
                Console.WriteLine("2. Bónusz 100 arany");
                string tárgy = "nyakkendő";
            }
            if(jutalom == 4)
            {
                Console.WriteLine("1. A jutalmad a következő lenne: 3 darab ló, értéke: 150 arany");
                Console.WriteLine("2. Bónusz 100 arany");
                string tárgy = "3 darab ló";
            }
            return tárgy;
        }
        public string párbeszéd_gyuri()
        {
            string name = "Gyuri";
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Az én nevem " + name + " nemrégiben mikor a földet kapáltam beleütköztünk valami ismeretlenbe, ami egy lejáró, és elképesztően nagy.");
                Console.WriteLine("Azt szeretném tőled kérni, hogy fedezd fel ezt a lejárót.");
                Console.WriteLine("Mi nem tudjuk meg tenni, mivel egy ősi sárkány jeleit lehet észrevenni a barlang belsejében.");
                Console.WriteLine("Ajánlott kard sebzés: 233~280");
                Console.WriteLine("Ajánlott védelem: 250");
                Console.WriteLine("Nehézségi fokozat: Nehéz");
            }
            return name;
        }
        public string jutalom_gyuri()
        {
            if(jutalom == 1)
            {
                Console.WriteLine("1. A következő lenne a jutalom: Luxus villa");
                Console.WriteLine("2. Bónusz: Sziget");
                string tárgy = "villa";
            }
            if(jutalom == 2)
            {
                Console.WriteLine("1. A következő lenne a jutalom: 2 hetes krumplifőzelék");
                Console.WriteLine("2. Bónusz: Legendás kard");
                string tárgy = "krumplifőzelék";
            }
            if(jutalom == 3)
            {
                Console.WriteLine("1. A következő lenne a jutalom: Földbirtok");
                Console.WriteLine("2. Bónusz: Földesúr rang");
                string tárgy = "földbirtok";
            }
            if(jutalom == 4)
            {
                Console.WriteLine("A következő lenne a jutalom: 1. Falu raktár közös használata");
                Console.WriteLine("2. Bónusz: Ajándék");
                string tárgy = "raktár";
            }
            return tárgy;
        }
    }
}
