using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGyakorlo
{
    class gacha_harc
    {
        static Random veletlen_harc = new Random();
        static Random veletlen_elemental = new Random();
        static Random veletlen_felszereles = new Random();
        static int kivalasztott_kard = veletlen_felszereles.Next(1, 4);
        static int kivalasztott_pancel = veletlen_felszereles.Next(1, 4);
        static string megkapott_kard = "";
        static string megkapott_pancel = "";
        static int krokodil_eletero = 200;
        static int jatekos_eletero = 100;
        static int teljes_sebzes;
        public string Gacha()
        {
            if (kivalasztott_kard == 1)
            {
                Console.WriteLine("A kard amit kaptál: Sárkány szabja. [Közepes]");
                Console.WriteLine("Támadási erő: 177~213");
                Console.WriteLine("Elementális erő: 23~36");
            }
            if (kivalasztott_kard == 2)
            {
                Console.WriteLine("A kard amit kaptál: Éles Penge [Közepes]");
                Console.WriteLine("Támadási erő: 56~95");
                Console.WriteLine("Elementális erő: 67~101");
            }
            if (kivalasztott_kard == 3)
            {
                Console.WriteLine("A kard amit kaptál: Hegy hasító [Epikus]");
                Console.WriteLine("Támadási erő: 233 ~ 280");
                Console.WriteLine("Elementális erő: 68 ~ 130");
            }
            return megkapott_kard;
        }
        public string pancelzat()
        {
            if (kivalasztott_pancel == 1)
            {
                Console.WriteLine("A felszerelés amit kaptál: Oroszlán vért [Közepes]");
                Console.WriteLine("Védelem: 150");
                int védelem = 150;
                int jatekos_eletero_veg = védelem + jatekos_eletero;
                Console.WriteLine("Így az életerőd " + jatekos_eletero + " -ról " + jatekos_eletero_veg + " -ra ugrik.");
            }
            if (kivalasztott_pancel == 2)
            {
                Console.WriteLine("A felszerelés amit kaptál: Acél vért [Rossz szerencse]");
                Console.WriteLine("Védelem: 85");
                int védelem = 85;
                int jatekos_eletero_veg = védelem + jatekos_eletero;
                Console.WriteLine("Így az életerőd " + jatekos_eletero + " -ról " + jatekos_eletero_veg + " -ra ugrik.");
            }
            if (kivalasztott_pancel == 3)
            {
                Console.WriteLine("A felszerelés amit kaptál: Hegy vért [Epikus]");
                Console.WriteLine("Védelem: 220");

                int védelem = 220;
                int jatekos_eletero_veg = védelem + jatekos_eletero;
                Console.WriteLine("Így az életerőd " + jatekos_eletero + " -ról " + jatekos_eletero_veg + " -ra ugrik.");
            }
            return megkapott_pancel;
        }
        public int szornyharc_krokodil()
        {
            if (kivalasztott_kard == 1)
            {
                int sebzes = veletlen_harc.Next(177, 213);
                int elemental_sebzes = veletlen_harc.Next(23, 36);
                int krokodil_eletero = 200;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Megközelítetted a krokodilt és " + teljes_sebzes + " sebzést okoztál, majd levágtad a lábát.");
                Console.WriteLine("Elementális sebzés: " + elemental_sebzes);
                Console.WriteLine("Kard vágásod pedig " + sebzes + " sebzést okozott.");
                Console.WriteLine("Így a krokodil életereje {0} ", krokodil_eletero - teljes_sebzes + " lett");
                if (krokodil_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő egy vágás!");
                    int krokodil_sebzes = veletlen_harc.Next(185, 213);
                    Console.WriteLine("A krokodil megragadja a lábad és ennyi sebzést okozz: " + krokodil_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy látszik ki kell egyezni egy döntetlenbe!");
                        Console.WriteLine("Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil egy hirtelen mozdulattal leharapta a fejedet! a " + teljes_eletero + "-ből " + "elveszítettél ennyit: " + krokodil_sebzes);
                        Console.WriteLine(eredmeny + " életerő, Véged van!");
                        Console.WriteLine("Majd ujjászületsz a legközelebbi városban.");
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy látszik ki kell egyezni egy döntetlenbe!");
                    }
                    return krokodil_eletero;
                }
                else if (krokodil_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a krokodilt.");
                    return krokodil_eletero;
                }
            }
            if (kivalasztott_kard == 2)
            {
                int sebzes = veletlen_harc.Next(56, 95);
                int elemental_sebzes = veletlen_harc.Next(67, 101);
                int krokodil_eletero = 200;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Megközelítetted a krokodilt és megdöfted, ezzel ennyi sebzést okoztál: " + teljes_sebzes);
                Console.WriteLine("Elementális sebzés: " + elemental_sebzes);
                Console.WriteLine("Kard vágásod pedig " + sebzes + " sebzést okozott.");
                Console.WriteLine("Így a krokodil életereje {0}", krokodil_eletero - teljes_sebzes + " lett");
                if (krokodil_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő egy vágás!");
                    int krokodil_sebzes = veletlen_harc.Next(185, 213);
                    Console.WriteLine("A krokodil megragadja a lábad és ennyi sebzést okozz: " + krokodil_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe. Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil egy hirtelen mozdulattal leharapta a fejedet! a " + teljes_eletero + "-ből " + "elveszítettél ennyit: " + krokodil_sebzes);
                        Console.WriteLine(eredmeny + " életerő, Véged van!");
                        Console.WriteLine("Majd ujjászületsz a legközelebbi városban.");
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe. Küldetés sikertelen!");
                        return krokodil_eletero;
                    }
                }
                else if (krokodil_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a krokodilt!");
                    return krokodil_eletero;
                }

            }
            if (kivalasztott_kard == 3)
            {
                int sebzes = veletlen_harc.Next(233, 280);
                int elemental_sebzes = veletlen_harc.Next(68, 130);
                int krokodil_eletero = 200;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Megközelítetted a krokodilt és " + teljes_sebzes + " sebzést okoztál, levágtad a fejét.");
                Console.WriteLine("Elementális sebzés: " + elemental_sebzes);
                Console.WriteLine("Kard vágásod pedig " + sebzes + " sebzést okozott.");
                Console.WriteLine("Így a krokodil életereje {0}", krokodil_eletero - teljes_sebzes + " lett");
                if (krokodil_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő egy vágás!");
                    int krokodil_sebzes = veletlen_harc.Next(185, 213);
                    Console.WriteLine("A krokodil megragadja a lábad és ennyi sebzést okozz: " + krokodil_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe. Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil egy hirtelen mozdulattal leharapta a fejedet! a " + teljes_eletero + "-ből " + "elveszítettél ennyit: " + krokodil_sebzes);
                        Console.WriteLine(eredmeny + " életerő, Véged van!");
                        Console.WriteLine("Majd ujjászületsz a legközelebbi városban.");
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - krokodil_sebzes;
                        Console.WriteLine("A krokodil az életedből levitt " + krokodil_sebzes + " -at." + " így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe. Küldetés sikertelen!");
                        return krokodil_eletero;
                    }
                }
                else if (krokodil_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a krokodilt!");
                    return krokodil_eletero;
                }

            }
            return teljes_sebzes;
        }
        public int harc_bandita()
        {
            if (kivalasztott_kard == 1)
            {
                int sebzes = veletlen_harc.Next(177, 213);
                int elemental = veletlen_elemental.Next(23, 36);
                int teljes_sebzes = sebzes + elemental;
                int bandita_eletero = 160;
                Console.WriteLine("Ahogyan követed a lábnyomokat, hirtelen felbukkan a célpont.");
                Console.WriteLine("Mivel nem egy erős egyénről van szó, settenkedés nélkül lecsapsz rá.");
                Console.WriteLine("Ennyi sebzést okozol neki: " + teljes_sebzes + " könnyedén meglepted.");
                Console.WriteLine("Ebből, normál sebzés: " + sebzes);
                Console.WriteLine("Ebből, elementális sebzés: " + elemental);
                if (bandita_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő az egy vágás, ugyanis sikerült kitérnie.");
                    int bandita_sebzes = veletlen_harc.Next(122, 190);
                    Console.WriteLine("A bandita feléd hajít egy kést és ennyi sebzést okozott: " + bandita_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eleterod = 100;
                        int teljes_eletero = védelem + jatekos_eleterod;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        Console.WriteLine("Ki kell egyezni egy döntetlenbe.");
                        Console.WriteLine("Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita feléd még egy kést sikeresen elhajított, amit nem tudtál kitérni");
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        if (bandita_sebzes > teljes_eletero)
                        {
                            Console.WriteLine("Úgy nézz ki elintézett téged...");
                            Console.WriteLine("Ujjászületsz a legközelebbi városban.");
                            return bandita_sebzes;
                        }
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe!");
                        Console.WriteLine("Küdletés sikertelen.");

                    }
                    return bandita_eletero;
                }
                else if (bandita_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a banditát!");
                    Console.WriteLine("Küldetés sikeres!");
                    return bandita_eletero;
                }
            }
            if (kivalasztott_kard == 2)
            {
                int sebzes = veletlen_harc.Next(56, 95);
                int elemental_sebzes = veletlen_harc.Next(67, 101);
                int bandita_eletero = 160;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Ahogyan követed a lábnyomokat, hirtelen felbukkan a célpont.");
                Console.WriteLine("Mivel nem egy erős egyénről van szó, settenkedés nélkül lecsapsz rá.");
                Console.WriteLine("Ennyi sebzést okozol neki: " + teljes_sebzes + " könnyedén meglepted.");
                Console.WriteLine("Ebből, normál sebzés: " + sebzes);
                Console.WriteLine("Ebből, elementális sebzés: " + elemental_sebzes);
                if (bandita_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő az egy vágás, ugyanis sikerült kitérnie.");
                    int bandita_sebzes = veletlen_harc.Next(122, 190);
                    Console.WriteLine("A bandita feléd hajít egy kést és ennyi sebzést okozott: " + bandita_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eleterod = 100;
                        int teljes_eletero = védelem + jatekos_eleterod;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        Console.WriteLine("Ki kell egyezni egy döntetlenbe.");
                        Console.WriteLine("Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita feléd még egy kést sikeresen elhajított, amit nem tudtál kitérni");
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        if (bandita_sebzes > teljes_eletero)
                        {
                            Console.WriteLine("Úgy nézz ki elintézett téged...");
                            Console.WriteLine("Ujjászületsz a legközelebbi városban.");
                            return bandita_sebzes;
                        }
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at." + "így az" + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe!");
                        Console.WriteLine("Küdletés sikertelen.");

                    }
                    return bandita_eletero;
                }
                else if (bandita_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a banditát, viszed az aranyat is!");
                    Console.WriteLine("Küldetés sikeres!");
                    return bandita_eletero;
                }

            }
            if (kivalasztott_kard == 3)
            {
                int sebzes = veletlen_harc.Next(233, 280);
                int elemental_sebzes = veletlen_harc.Next(68, 130);
                int bandita_eletero = 160;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Ahogyan követed a lábnyomokat, hirtelen felbukkan a célpont.");
                Console.WriteLine("Mivel nem egy erős egyénről van szó, settenkedés nélkül lecsapsz rá.");
                Console.WriteLine("Ennyi sebzést okozol neki: " + teljes_sebzes + " könnyedén meglepted.");
                Console.WriteLine("Ebből, normál sebzés: " + sebzes);
                Console.WriteLine("Ebből, elementális sebzés: " + elemental_sebzes);
                if (bandita_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem volt elegendő az egy vágás, ugyanis sikerült kitérnie.");
                    int bandita_sebzes = veletlen_harc.Next(122, 190);
                    Console.WriteLine("A bandita feléd hajít egy kést és ennyi sebzést okozott: " + bandita_sebzes);
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eleterod = 100;
                        int teljes_eletero = védelem + jatekos_eleterod;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at. " + "így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Ki kell egyezni egy döntetlenbe.");
                        Console.WriteLine("Küldetés sikertelen!");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita feléd egy másik kést is sikeresen elhajított, amit nem tudtál kitérni");
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at. " + "így az " + eredmeny, "{0} lett!");
                        if (bandita_sebzes > teljes_eletero)
                        {
                            Console.WriteLine("Úgy nézz ki elintézett téged...");
                            Console.WriteLine("Ujjászületsz a legközelebbi városban.");
                            return bandita_sebzes;
                        }
                        else 
                        {
                            Console.WriteLine("Ez nem sokon múlott!");
                            Console.WriteLine("Küldetés sikertelen.");
                        }
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - bandita_sebzes;
                        Console.WriteLine("A bandita az életerődből levitt " + bandita_sebzes + " -at. " + "így az " + eredmeny, "{0} lett!");
                        Console.WriteLine("Úgy nézz ki, ki kell egyezni egy döntetlenbe!");
                        Console.WriteLine("Küdletés sikertelen.");

                    }
                    return bandita_eletero;
                }
                else if (bandita_eletero < teljes_sebzes)
                {
                    Console.WriteLine("Legyőzted a banditát!");
                    Console.WriteLine("Küldetés sikeres!");
                    return bandita_eletero;
                }
            }
            return teljes_sebzes;
        }
        public int harc_sarkany()
        {
            if(kivalasztott_kard == 1)
            {
                int sebzes = veletlen_harc.Next(177, 213);
                int elemental = veletlen_elemental.Next(23, 36);
                int teljes_sebzes = sebzes + elemental;
                int sarkany_eletero = 335;
                Console.WriteLine("Lassan settenkedsz a barlangban..hatalmas csend van.");
                Console.WriteLine("Véletlenül felrugtál egy követ, ami leesett egy mély lyukba.");
                Console.WriteLine("Valamilyen oknál fogva a kő hangja igazán eltompult mikor leesett.");
                Console.WriteLine("Egy sárkány üvöltést hallasz vissza válaszul!");
                Console.WriteLine("Kardod gyorsan előrántottad");
                Console.WriteLine("Ennyi sebzést okoztál neki: "+teljes_sebzes+" éppenhogy képes voltál elkapni.");
                Console.WriteLine("Ebből normál sebzés: "+sebzes);
                Console.WriteLine("Ebből elementális sebzés: "+elemental);
                if(sarkany_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem sikerült elintézni egy vágással!");
                    int sarkany_sebzes = veletlen_harc.Next(290, 350);
                    Console.WriteLine("A sárkány beléd harapott!");
                    if(kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány leharapta a fél testedet, nem voltál elég gyors. "+ sarkany_sebzes+" sebzést vitt be a sárkány, az életerőd "+eredmeny+" lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if(kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány eltaposott téged, esélyed sem volt ebben a páncélban túlélni. "+sarkany_sebzes+" sebzést vitt be a sárkány, az életerőd "+eredmeny+" lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if(kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány elkapta az egyik kezedet és nem akarja elengedni. "+sarkany_sebzes+" sebzést vitt be a sárkány, az életerőd így "+eredmeny+" lett.");
                        if(teljes_eletero > sarkany_sebzes)
                        {
                            Console.WriteLine("Megvoltak az esélyeid a győzelemre, de sajnos nem sikerült. A falu emlékezni fog a hőstetteidre!");
                            Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                            return sarkany_eletero;
                        }
                        else if(teljes_eletero < sarkany_sebzes)
                        {
                            Console.WriteLine("Szerencséd volt, hogy nem ölt meg téged. A sárkányt sikeresen legyengítetted, de ezt már sajnos a következő utazóra kell hagynod, neked most az a dolgod hogy ne vérez el.");
                            Console.WriteLine("Döntetlen! Küldetés sikertelen.");
                            return sarkany_eletero;
                        }
                    }
                }
                else if(teljes_sebzes > sarkany_eletero)
                {
                    Console.WriteLine("A sárkányt sikeresen legyőzted! Kivitted a játékot, és gazdag lettél.");
                }
            }
            if(kivalasztott_kard == 2)
            {
                int sebzes = veletlen_harc.Next(56, 95);
                int elemental = veletlen_harc.Next(67, 101);
                int sarkany_eletero = 335;
                int teljes_sebzes = sebzes + elemental;
                Console.WriteLine("Lassan settenkedsz a barlangban..hatalmas csend van.");
                Console.WriteLine("Véletlenül felrugtál egy követ, ami leesett egy mély lyukba.");
                Console.WriteLine("Valamilyen oknál fogva a kő hangja igazán eltompult mikor leesett.");
                Console.WriteLine("Egy sárkány üvöltést hallasz vissza válaszul!");
                Console.WriteLine("Kardod gyorsan előrántottad");
                Console.WriteLine("Ennyi sebzést okoztál neki: " + teljes_sebzes + " éppenhogy képes voltál elkapni.");
                Console.WriteLine("Ebből normál sebzés: " + sebzes);
                Console.WriteLine("Ebből elementális sebzés: " + elemental);
                if (sarkany_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem sikerült elintézni egy vágással!");
                    int sarkany_sebzes = veletlen_harc.Next(290, 350);
                    Console.WriteLine("A sárkány beléd harapott!");
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány leharapta a fél testedet, nem voltál elég gyors. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd " + eredmeny + " lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány eltaposott téged, esélyed sem volt ebben a páncélban túlélni. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd " + eredmeny + " lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány elkapta az egyik kezedet és nem akarja elengedni. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd így " + eredmeny + " lett.");
                        if (teljes_eletero > sarkany_sebzes)
                        {
                            Console.WriteLine("Megvoltak az esélyeid a győzelemre, de sajnos nem sikerült. A falu emlékezni fog a hőstetteidre!");
                            Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                            return sarkany_eletero;
                        }
                        else if (teljes_eletero < sarkany_sebzes)
                        {
                            Console.WriteLine("Szerencséd volt, hogy nem ölt meg téged. A sárkányt sikeresen legyengítetted, de ezt már sajnos a következő utazóra kell hagynod, neked most az a dolgod hogy ne vérez el.");
                            Console.WriteLine("Döntetlen! Küldetés sikertelen.");
                            return sarkany_eletero;
                        }
                    }
                }
                else if (teljes_sebzes > sarkany_eletero)
                {
                    Console.WriteLine("A sárkányt sikeresen legyőzted! Kivitted a játékot, és gazdag lettél.");
                }
            }
            if(kivalasztott_kard == 3)
            {
                int sebzes = veletlen_harc.Next(223, 280);
                int elemental_sebzes = veletlen_harc.Next(68, 130);
                int sarkany_eletero = 335;
                int teljes_sebzes = sebzes + elemental_sebzes;
                Console.WriteLine("Lassan settenkedsz a barlangban..hatalmas csend van.");
                Console.WriteLine("Véletlenül felrugtál egy követ, ami leesett egy mély lyukba.");
                Console.WriteLine("Valamilyen oknál fogva a kő hangja igazán eltompult mikor leesett.");
                Console.WriteLine("Egy sárkány üvöltést hallasz vissza válaszul!");
                Console.WriteLine("Kardod gyorsan előrántottad");
                Console.WriteLine("Levágtad a sárkány bal kezét,:" +teljes_sebzes+" sebzést okoztál neki.");
                Console.WriteLine("Ebből normál sebzés: "+sebzes);
                Console.WriteLine("Ebből elementális sebzés: "+elemental_sebzes);
                if (sarkany_eletero > teljes_sebzes)
                {
                    Console.WriteLine("Nem sikerült elintézni egy vágással!");
                    int sarkany_sebzes = veletlen_harc.Next(290, 350);
                    Console.WriteLine("A sárkány beléd harapott!");
                    if (kivalasztott_pancel == 1)
                    {
                        int védelem = 150;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány leharapta a fél testedet, nem voltál elég gyors. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd " + eredmeny + " lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if (kivalasztott_pancel == 2)
                    {
                        int védelem = 85;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány eltaposott téged, esélyed sem volt ebben a páncélban túlélni. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd " + eredmeny + " lett.");
                        Console.WriteLine("Ujjászülettél a legközelebbi városban! Küldetés sikertelen.");
                    }
                    if (kivalasztott_pancel == 3)
                    {
                        int védelem = 220;
                        int jatekos_eletero = 100;
                        int teljes_eletero = védelem + jatekos_eletero;
                        int eredmeny = teljes_eletero - sarkany_sebzes;
                        Console.WriteLine("A sárkány elkapta az egyik kezedet és nem akarja elengedni. " + sarkany_sebzes + " sebzést vitt be a sárkány, az életerőd így " + eredmeny + " lett.");
                        if (teljes_eletero < sarkany_sebzes)
                        {
                            Console.WriteLine("Megvoltak az esélyeid a győzelemre, de sajnos nem sikerült. A falu emlékezni fog a hőstetteidre!");
                            return sarkany_eletero;
                        }
                        else if (teljes_eletero > sarkany_sebzes)
                        {
                            Console.WriteLine("Szerencséd volt, hogy nem ölt meg téged. A sárkányt sikeresen legyengítetted, de ezt már sajnos a következő utazóra kell hagynod, neked most az a dolgod hogy ne vérez el.");
                            Console.WriteLine("Döntetlen! Küldetés sikertelen.");
                            return sarkany_eletero;
                        }
                    }
                }
                else if (teljes_sebzes > sarkany_eletero)
                {
                    Console.WriteLine("A sárkányt sikeresen legyőzted! Kivitted a játékot, és gazdag lettél.");
                }
            }
            return teljes_sebzes;
        }
    }
}

