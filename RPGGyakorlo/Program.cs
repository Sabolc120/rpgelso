using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGyakorlo
{
    class ellenorzo
    {
        bool meghalt;
    }
    class Program
    {
        static npcs párbeszed = new npcs();
        static void Main(string[] args)
        {
            Console.WriteLine("Üdvözöllek a béna világban!");
            Console.WriteLine("Hogy hívjanak?");
            string jatekos_nev = Console.ReadLine();
            Console.WriteLine(jatekos_nev+" Sorsoljuk ki milyen felszerelésed lesz.");
            gacha_harc felszereles = new gacha_harc();
            ellenorzo vege = new ellenorzo();
            string kard = felszereles.Gacha();
            string pancel = felszereles.pancelzat();
            Console.WriteLine("Folytatáshoz nyomja le az 1-t.");
            try
            {
                int bevitel = Convert.ToInt32(Console.ReadLine());
                if (bevitel == 1)
                {
                    string parbeszed = párbeszed.párbeszéd_aladin();
                    string jutalom = párbeszed.kuldetes_jutalom_aladin();
                    Console.WriteLine("Elfogadod a küldetést? Igen: 1, Nem: 2");
                    int elso_kuldetes_valasz = Convert.ToInt32(Console.ReadLine());
                    if(elso_kuldetes_valasz == 1)
                    {
                        int tamadasi_sebzes = felszereles.szornyharc_krokodil();
                        string kovetkezo = párbeszed.párbeszéd_Szenyor();
                        string jutalom_szenyor = párbeszed.jutalom_Szenyor();
                    }
                    if(elso_kuldetes_valasz == 2)
                    {
                        string parbeszed_szenyor = párbeszed.párbeszéd_Szenyor();
                        string jutalom_szenyor = párbeszed.jutalom_Szenyor();
                    }
                    Console.WriteLine("Elfogadod a küldetést? Igen: 1, Nem: 2");
                    int masodik_kuldetes_valasz = Convert.ToInt32(Console.ReadLine());
                    if(masodik_kuldetes_valasz == 1)
                    {
                        int tamadasi_sebzes = felszereles.harc_bandita();
                        string kovetkezo = párbeszed.párbeszéd_gyuri();
                        string jutalom_gyuri = párbeszed.jutalom_gyuri();

                    }
                    if(masodik_kuldetes_valasz == 2)
                    {
                        string párbeszéd_gyuri = párbeszed.párbeszéd_gyuri();
                        string jutalom_gyuri = párbeszed.jutalom_gyuri();
                    }
                    Console.WriteLine("Elfogadod a küldetést? Igen: 1, Nem: 2");
                    int harmadik_kuldetes_valasz = int.Parse(Console.ReadLine());
                    if(harmadik_kuldetes_valasz == 1)
                    {
                        int harc = felszereles.harc_sarkany();
                        Console.WriteLine("A kalandod itt véget ért, köszönöm szépen hogy megnézted ezt a kis programot! Még többel fogok jönni a jövőben.");
                        Console.WriteLine("Ez volt a béna világ első része.");
                    }
                    if(harmadik_kuldetes_valasz == 2)
                    {
                        Console.WriteLine("Akkor majd keresünk valaki mást.");
                        Console.WriteLine("A kalandod itt véget ért, köszönöm szépen hogy megnézted ezt a kis programot! Még többel fogok jönni a jövőben.");
                        Console.WriteLine("Ez volt a béna világ első része.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Nem lehet betűt megadni.");
            }   
            Console.ReadLine();
        }
    }
}
