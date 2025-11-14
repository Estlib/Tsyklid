string[] konsoolid = { "PLEIŠTEIŠON 1", "nintendo witch", "valve steam machine" };

//List<string> mängud = new List<string>();

//foreach (var konsool in konsoolid)
//{
//    Console.WriteLine(konsool);
//}

//for (int i = 0; i < konsoolid.Length; i++)
//{
//    Console.WriteLine(konsoolid[i]);
//}

//string currentEntry = ""; //ajutine muutuja mis hoiab tekstitüüpi andmeid, hetkel tühi

//while (currentEntry == "") //while tsükkel mis toiib niikaua kuni currententry on tühi
//{
//    Console.WriteLine("Sisesta mäng või kirjuta \"ei taha\" kui soovid esitust lõpetada");
//    //esitame kasutajale sõnumi
//    currentEntry = Console.ReadLine();
//    //paneme ajutisse muutujasse info kasutajalt
//    if (currentEntry =="ei taha") //kui kasutaja kirjutas "ei taha", teeme ifi sisu
//    {
//        break; //break katkestab kogu tsükli, peatades sisestamise
//    }
//    //mängud[i] = currentEntry;
//    mängud.Add(currentEntry); //lisame loendile otsa kasutaja sisestatud info
//    currentEntry = ""; //omistame muutujasse currententry uuesti tühja sisestuse, et tsükkel jätkuks.
//}

//Console.WriteLine("\n\n\n");

//foreach (var mäng in mängud)
//{
//    Console.WriteLine(mäng);
//}

Console.WriteLine("Mis on su lemmikvärvid? Sisesta palun ükshaaval\nKui rohkem värve ei ole, kirjuta \"rohkem pole\"");
List<string> kasutajaVärvid = new List<string>();

string sisestus = "";
do
{
    Console.WriteLine("Sisesta 1 värv korraga:");
    sisestus = Console.ReadLine();

    if (sisestus != "rohkem pole")
    {
        kasutajaVärvid.Add(sisestus);
    }

} while (sisestus != "rohkem pole");

foreach (var värv in kasutajaVärvid)
{
    switch (värv)
    {
        // punane, oranz, kollane, roheline, helesinine, tumeroheline, tumesinine, lilla,
        // roosa, pruun, must, valge, hall, värvi-ei-tunta
        // roosa & oranz - neid värve ei ole, tagasta sõnum mis on värevispetsiifiline
        case "punane":
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- p u n a n e -*-*-");
            break;
        /* LISAGE ISESEISVALT KÕIKIDE MUUDE VÄRVIDE CASED */
        case "oranz":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Oranz pole saadaval");
            break;
        case "kollane":
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- k o l l a n e -*-*-");
            break;
        case "roheline":
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- r o h e l i n e -*-*-");
            break;
        case "helesinine":
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- h e l e s i n i n e -*-*-");
            break;
        case "sinine":
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- s i n i n e -*-*-");
            break;
        case "tumesinine":
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- t u m e s i n i n e -*-*-");
            break;
        case "lilla":
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- l i l l a ? -*-*-");
            break;
        case "roosa":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kahjuks ei ole roosa saadaval");
            break;
        case "pruun":
            Console.BackgroundColor = ConsoleColor.DarkYellow;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- p r u u n ? -*-*-");
            break;
        case "must":
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-*-*- m u s t -*-*-");
            break;
        case "valge":
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- v a l g e -*-*-");
            break;
        case "hall":
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("-*-*- h a l l -*-*-");
            break;

        default:
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Ei tunne sellist värvi{värv}");
            break;
    }
}








//5 värvituvastus värvidele: punane oranz kollane roheline
// helesinine tumesinine lilla roosa pruun must ja valge
//Console.WriteLine("Mis on sinu lemmikvärv?:");
//string favColour = Console.ReadLine();
//if (favColour == "punane")
//{
//    Console.BackgroundColor = ConsoleColor.Red;
//}
//else if (favColour == "oranz")
//{
//    Console.WriteLine("Kahjuks ei ole oranz saadaval");
//}
//else if (favColour == "kollane")
//{
//    Console.BackgroundColor = ConsoleColor.Yellow;
//}
//else if (favColour == "roheline")
//{
//    Console.BackgroundColor = ConsoleColor.DarkGreen;
//}
//else if (favColour == "helesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Cyan;
//}
//else if (favColour == "tumesinine")
//{
//    Console.BackgroundColor = ConsoleColor.Blue;
//}
//else if (favColour == "lilla")
//{
//    Console.BackgroundColor = ConsoleColor.DarkCyan;
//}
//else if (favColour == "roosa")
//{
//    Console.WriteLine("Kahjuks roosat anda ei ole");
//}
//else if (favColour == "pruun")
//{
//    Console.BackgroundColor = ConsoleColor.DarkYellow;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.Black;
//    Console.ForegroundColor = ConsoleColor.White;
//}
//else if (favColour == "must")
//{
//    Console.BackgroundColor = ConsoleColor.White;
//    Console.ForegroundColor = ConsoleColor.Black;
//}
//else
//{
//    Console.WriteLine("ei tea seda värvi");
//}
//Console.WriteLine("The colour has maybe changed!!!!!");


