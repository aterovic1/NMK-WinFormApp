using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlinikaOrdinacija;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;

namespace NasaMalaKlinika
{
    class Program
    {
        static Doktor doktor17395_1 = new Doktor("Meho", "Karabeg", Convert.ToDateTime("05.12.1975."), "0512975114528", "Behdzeta Mutevelica 56", Spol.musko, BracnoStanje.ozenjen, 3500, "mkarabeg", "12345");
        static Doktor doktor17395_2 = new Doktor("Almir", "Kardovic", Convert.ToDateTime("15.08.1989."), "1508989147854", "Zmaja od Bosne 24", Spol.musko, BracnoStanje.neozenjen, 3000, "akardovic", "12345");
        /*static Doktor doktor17395_3 = new Doktor("Ena", "Hodzic", Convert.ToDateTime("07.12.1987."), "0712987452369", "Aleja Bosne srebrene 47", Spol.zensko, BracnoStanje.razveden, 2700);
        static Doktor doktor17395_4 = new Doktor("Alma", "Masic", Convert.ToDateTime("12.01.1965."), "1201965211478", "Safeta Zajke 158", Spol.zensko, BracnoStanje.ozenjen, 1900);
        static Doktor doktor17395_5 = new Doktor("Arnes", "Sehovic", Convert.ToDateTime("21.07.1970."), "2107970856654", "Alibega Firdusa 77", Spol.musko, BracnoStanje.razveden, 2350);
        static Doktor doktor17395_6 = new Doktor("Irma", "Dedovic", Convert.ToDateTime("29.06.1979."), "2906979147521", "Paromlinska 63", Spol.zensko, BracnoStanje.ozenjen, 4100);
        static Doktor doktor17395_7 = new Doktor("Asim", "Omerovic", Convert.ToDateTime("01.11.1984."), "0111984663281", "Nedima Filipovica 12", Spol.musko, BracnoStanje.neozenjen, 3560);
        static Doktor doktor17395_8 = new Doktor("Lejla", "Durakovic", Convert.ToDateTime("10.03.1976."), "1003976541219", "Avdage Sahinagica 19", Spol.zensko, BracnoStanje.udovac, 2180);
        static Doktor doktor17395_9 = new Doktor("Osman", "Kustura", Convert.ToDateTime("14.02.1969."), "1402969365241", "Kasindolska 147", Spol.musko, BracnoStanje.ozenjen, 3250);*/

        /*static Karton karton17395_1 = new Karton("Polen", "Upala pluca", "Lose");
        static Karton karton17395_2 = new Karton("Ne", "Bronhitis", "Dobro");
        static Karton karton17395_3 = new Karton("Duhan", "Ospice", "Odlicno");
        static Karton karton17395_4 = new Karton("Ne", "Infarkt", "Veoma lose");
        static Karton karton17395_5 = new Karton("Ne", "Ne", "Lose");
        static Karton karton17395_6 = new Karton("Kikiriki", "Ne", "Veoma dobro");
        static Karton karton17395_7 = new Karton("Grinje", "Mozdani udar", "Dobro");
        static Karton karton17395_8 = new Karton("Joha", "Ne", "Odlicno");
        static Karton karton17395_9 = new Karton("Ne", "Srcani udar", "Dobro");
        static Karton karton17395_10 = new Karton("Gluten", "Rak pluca", "Veoma lose");
        static Karton karton17395_11 = new Karton("Duhan", "Ne", "Lose");
        static Karton karton17395_12 = new Karton("Ne", "Povisen pritisak", "Veoma dobro");

        static List<Pregled> pregledi1 = new List<Pregled> { new Pregled(ordinacija17395_1), new Pregled(ordinacija17395_3), new Pregled(ordinacija17395_6) };
        static List<Pregled> pregledi2 = new List<Pregled> { new Pregled(ordinacija17395_2), new Pregled(ordinacija17395_1) };
        static List<Pregled> pregledi3 = new List<Pregled> { new Pregled(ordinacija17395_9), new Pregled(ordinacija17395_5), new Pregled(ordinacija17395_8) };
        static List<Pregled> pregledi4 = new List<Pregled> { new Pregled(ordinacija17395_8), new Pregled(ordinacija17395_4) };
        static List<Pregled> pregledi5 = new List<Pregled> { new Pregled(ordinacija17395_7) };
        static List<Pregled> pregledi6 = new List<Pregled> { new Pregled(ordinacija17395_6), new Pregled(ordinacija17395_7), new Pregled(ordinacija17395_1) };
        static List<Pregled> pregledi7 = new List<Pregled> { new Pregled(ordinacija17395_2) };
        static List<Pregled> pregledi8 = new List<Pregled> { new Pregled(ordinacija17395_5), new Pregled(ordinacija17395_9) };
        static List<Pregled> pregledi9 = new List<Pregled> { new Pregled(ordinacija17395_4), new Pregled(ordinacija17395_1), new Pregled(ordinacija17395_3) };
        static List<Pregled> pregledi10 = new List<Pregled> { new Pregled(ordinacija17395_2), new Pregled(ordinacija17395_6) };
        static List<Pregled> pregledi11 = new List<Pregled> { new Pregled(ordinacija17395_7), new Pregled(ordinacija17395_8), new Pregled(ordinacija17395_5), new Pregled(ordinacija17395_4) };
        static List<Pregled> pregledi12 = new List<Pregled> { new Pregled(ordinacija17395_2), new Pregled(ordinacija17395_4), new Pregled(ordinacija17395_6), new Pregled(ordinacija17395_1), new Pregled(ordinacija17395_9) };

        static Pacijent pacijent17395_1 = new Pacijent("Elvis", "Presley", Convert.ToDateTime("14.02.1969."), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.neozenjen, karton17395_1, pregledi1);
        static Pacijent pacijent17395_2 = new Pacijent("Nino", "Prses", Convert.ToDateTime("18.12.1999."), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.razveden, karton17395_2, pregledi2);
        static Pacijent pacijent17395_3 = new HitniPacijent("Selma", "Bajrami", Convert.ToDateTime("14.07.2001."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.udovac, karton17395_3, pregledi3, "reanimacija");
        static Pacijent pacijent17395_4 = new Pacijent("Aida", "Halilovic", Convert.ToDateTime("06.06.2000."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.ozenjen, karton17395_4, pregledi4);
        static Pacijent pacijent17395_5 = new Pacijent("Amar", "Cizmic", Convert.ToDateTime("11.08.1959"), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.neozenjen, karton17395_5, pregledi5);
        static Pacijent pacijent17395_6 = new HitniPacijent("Tarik", "Pribisic", Convert.ToDateTime("19.06.1988."), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.razveden, karton17395_6, pregledi6, "masaza srca");
        static Pacijent pacijent17395_7 = new PacijentSmrtniIshod("Benjamin", "Franklin", Convert.ToDateTime("29.05.1996."), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.ozenjen, "masaza srca", Convert.ToDateTime("17.11.2017"), "srcani udar");
        static Pacijent pacijent17395_8 = new Pacijent("Nikola", "Tesla", Convert.ToDateTime("17.12.2005."), "1402969145258", "Kasindolska 147", Spol.musko, BracnoStanje.ozenjen, karton17395_8, pregledi8);
        static Pacijent pacijent17395_9 = new HitniPacijent("Marija", "Maric", Convert.ToDateTime("09.10.1979."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.udovac, karton17395_9, pregledi9, "vjestacko disanje");
        static Pacijent pacijent17395_10 = new HitniPacijent("Hana", "Hanic", Convert.ToDateTime("06.09.1984."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.razveden, karton17395_10, pregledi10, "gips");
        static Pacijent pacijent17395_11 = new Pacijent("Esma", "Muhovic", Convert.ToDateTime("03.02.1991."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.ozenjen, karton17395_11, pregledi11);
        static Pacijent pacijent17395_12 = new Pacijent("Fazila", "Gagula", Convert.ToDateTime("01.01.2000."), "1402969145258", "Kasindolska 147", Spol.zensko, BracnoStanje.neozenjen, karton17395_12, pregledi12);*/

        static List<Uposlenik> ListaUpos = new List<Uposlenik> { doktor17395_1, doktor17395_2, /*doktor17395_3, doktor17395_4, doktor17395_5, doktor17395_6, doktor17395_7, doktor17395_8, doktor17395_9*/ };

        /*static List<Pacijent> ListaPac = new List<Pacijent> { pacijent17395_1, pacijent17395_2, pacijent17395_3, pacijent17395_4, pacijent17395_5, pacijent17395_6, pacijent17395_7, pacijent17395_8, pacijent17395_9, pacijent17395_10, pacijent17395_11, pacijent17395_12 };*/

        static Ordinacija ordinacija17395_1 = new Ordinacija("Kardioloski pregled", doktor17395_1, 600);
        static Ordinacija ordinacija17395_2 = new Ordinacija("Dermatoloski pregled", doktor17395_2, 450);
        /*static Ordinacija ordinacija17395_3 = new Ordinacija("Ortopedski pregled", doktor17395_3, 390);
        static Ordinacija ordinacija17395_4 = new Ordinacija("Internisticki pregled", doktor17395_4, 710);
        static Ordinacija ordinacija17395_5 = new Ordinacija("Otorinolaringoloski pregled", doktor17395_5, 480);
        static Ordinacija ordinacija17395_6 = new Ordinacija("Oftamoloski pregled", doktor17395_6, 185);
        static Ordinacija ordinacija17395_7 = new Ordinacija("Laboratorijski pregled", doktor17395_7, 720);
        static Ordinacija ordinacija17395_8 = new Ordinacija("Stomatoloski pregled", doktor17395_8, 540);
        static Ordinacija ordinacija17395_9 = new Ordinacija("Opsti pregled", doktor17395_9, 300);*/

        static List<Ordinacija> listaOrd = new List<Ordinacija> { ordinacija17395_1, ordinacija17395_2/*, ordinacija17395_3, ordinacija17395_4, ordinacija17395_5, ordinacija17395_6, ordinacija17395_7, ordinacija17395_8, ordinacija17395_9*/ };

        static Klinika klinika17395_1 = new Klinika(listaOrd, ListaUpos);
        

        private static void glavniMeni(Osoba o)
        {
            Console.WriteLine("---------------------------------------\n" + "Dobro došli! Odaberite jednu od opcija:\n");
            List<string> meniOdabir = new List<string> { "Registruj/Briši pacijenta", "Prikaži raspored pregleda pacijenta", "Kreiranje kartona pacijenta", "Pretraga kartona pacijenta", "Registruj novi pregled", "Analiza sadržaja", "Naplata" };
            if(o is Doktor)
            {
                Console.WriteLine("1. {0}\n2. {1}\n3. {2}\n4. Izlaz\n", meniOdabir[1], meniOdabir[3], meniOdabir[4]);
            }
            else if(o is Uposlenik)
            {
                Console.WriteLine("1. {0}\n2. {1}\n3. {2}\n4. {3}\n5. {4}\n6. Izlaz\n", meniOdabir[0], meniOdabir[1], meniOdabir[2], meniOdabir[5], meniOdabir[6]);
            }
            else
            {

            }
            Console.WriteLine("---------------------------------------\n");
        }
        private static void PacijentRegistracijaBrisanje()
        {
            string opcija;
            Console.WriteLine("Unesite 'r' za registraciju novog pacijenta, odnosno 'b' za brisanje postojećeg pacijenta");
            opcija = Console.ReadLine();
            if (opcija == "r")
            {
                PacijentRegistracija();
            }
            else if (opcija == "b")
            {
                PacijentBrisanje();
            }
        }
        private static void PacijentRegistracija()
        {
            string ime, prezime, matBr, adresa;
            DateTime datRodjenja;
            Spol s;
            BracnoStanje brSt;
            Console.WriteLine("Da li je u pitanju hitni pacijent? d - DA, n - NE");
            bool hitni = (Console.ReadLine() == "d") ? true : false;
            string prvaPomoc = "";
            bool smrtniIshod = false;
            string uzrokSmrti = "";
            DateTime vrijemeSmrti = DateTime.Now;
            if (hitni)
            {
                Console.WriteLine("Koji vid prve pomoci je pruzen pacijentu: ");
                prvaPomoc = Console.ReadLine();
                Console.WriteLine("Da li je nastupio smrtni ishod? d - DA, n - NE");
                smrtniIshod = (Console.ReadLine() == "d") ? true : false;
                if (smrtniIshod)
                {
                    Console.WriteLine("Vrijeme smrti: ");
                    vrijemeSmrti = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Uzrok smrti: ");
                    uzrokSmrti = Console.ReadLine();
                }
            }
            Console.WriteLine("Unesite sljedeće podatke o pacijentu (ENTER nakon svakog unosa): ime, prezime, datum rođenja, matični broj, adresa stanovanja");
            ime = Console.ReadLine();
            prezime = Console.ReadLine();
            datRodjenja = Convert.ToDateTime(Console.ReadLine());
            matBr = Console.ReadLine();
            adresa = Console.ReadLine();
            string opcija;
            int opcija1;
            Console.WriteLine("Spol pacijenta: m - muško, f - žensko");
            opcija = Console.ReadLine();
            if (opcija == "m")
                s = Spol.musko;
            else
                s = Spol.zensko;
            Console.WriteLine("Bracno stanje pacijenta: 1. oženjen/udata, 2. neoženjen/neudata, 3. razveden/razvedena, 4. udovac/udovica");
            opcija1 = Convert.ToInt32(Console.ReadLine());
            if (opcija1 == 1)
                brSt = BracnoStanje.ozenjen;
            else if (opcija1 == 2)
                brSt = BracnoStanje.neozenjen;
            else if (opcija1 == 3)
                brSt = BracnoStanje.razveden;
            else
                brSt = BracnoStanje.udovac;
            Pacijent pacijent;
            if (!hitni)
            {
                pacijent = new Pacijent(ime, prezime, datRodjenja, matBr, adresa, s, brSt);
            }
            else
            {
                if (!smrtniIshod)
                {
                    pacijent = new HitniPacijent(ime, prezime, datRodjenja, matBr, adresa, s, brSt, prvaPomoc);
                }
                else
                {
                    pacijent = new PacijentSmrtniIshod(ime, prezime, datRodjenja, matBr, adresa, s, brSt, prvaPomoc, vrijemeSmrti, uzrokSmrti);
                }
            }
            klinika17395_1.RegistrirajPacijenta(pacijent);
            if (pacijent is PacijentSmrtniIshod)
                return;
            // anamneza ide u PacijentKreiranjeKartona()
            int odabirPregleda;
            int i;
            while(true)
            {
                i = 1;
                Console.WriteLine("Izaberite tip pregleda: (0 za izlaz)");
                klinika17395_1.ordinacije.ForEach(x => Console.WriteLine("{0}. {1}", i++, x.tipPregleda));
                odabirPregleda = Convert.ToInt32(Console.ReadLine());
                if (odabirPregleda == 0)
                    break;
                Ordinacija ordinacija = klinika17395_1.ordinacije.ElementAt(odabirPregleda - 1);
                klinika17395_1.RegistrirajNoviPregled(pacijent, ordinacija, new Pregled(ordinacija));
            }
            // prikaz rasporeda obilaska ordinacija 
            klinika17395_1.PrikaziPregledePacijenta(pacijent);
            // nakon registracije pacijenta potrebno je kreirati karton, jer u suprotnom se ne moze obaviti pregled!
        }
        private static void PacijentBrisanje()
        {
            int id;
            Console.WriteLine("Unesite id pacijenta za brisanje: ");
            id = Convert.ToInt32(Console.ReadLine());
            Pacijent p = klinika17395_1.DajPacijentaSaId(id);
            klinika17395_1.IzbrisiPacijenta(p);
            Console.WriteLine("Pacijent uspjesno obrisan.\n");
        }

        private static void PacijentRasporedPregleda()
        {
            int id;
            Console.WriteLine("Unesite id pacijenta: ");
            id = Convert.ToInt32(Console.ReadLine());
            Pacijent p = klinika17395_1.DajPacijentaSaId(id);
            klinika17395_1.PrikaziPregledePacijenta(p);
        }
        private static void RegistracijaNovogPregleda()
        {
            //vrsenje pregleda i izmjena kartona 
            //nakon sto je doktor obavio pregled, upisuje rezultat i terapiju i unosi u e-karton
            Console.WriteLine("Odaberite ordinaciju: ");
            int i = 1;
            klinika17395_1.ordinacije.ForEach(x => Console.WriteLine("{0}. {1}", i++, x.tipPregleda));
            i = Convert.ToInt32(Console.ReadLine());
            Ordinacija o = klinika17395_1.ordinacije.ElementAt(i - 1);
            Console.WriteLine("Red cekanja za ordinaciju:\n");
            Console.WriteLine(o.PrikaziListuCekanja());
            Pacijent pac = o.listaCekanja.First();
            Console.WriteLine("Unos pregleda za pacijenta: {0} {1}\n", pac.ime, pac.prezime);
            DateTime dat;
            Console.WriteLine("Unesite datum pregleda: ");
            dat = Convert.ToDateTime(Console.ReadLine());
            string rezultat, terapija;
            Console.WriteLine("Unesite rezultat pregleda: ");
            rezultat = Console.ReadLine();
            Console.WriteLine("Unesite terapiju: ");
            terapija = Console.ReadLine();
            Pregled preg = pac.zakazaniPregledi.Find(x => x.ordinacija.tipPregleda == o.tipPregleda);
            pac.ObaviPregled(dat, rezultat, terapija, preg, o);
        }
        private static void PacijentPretragaKartona()
        {
            int id;
            Console.WriteLine("Unesite id pacijenta: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(klinika17395_1.PrikaziKartonPacijenta(id));
        }
        private static void PacijentKreiranjeKartona()
        {
            //pitanja: alergija, ranije bolesti, zdravstveno stanje u porodici
            int id;
            Console.WriteLine("Unesite id pacijenta: ");
            id = Convert.ToInt32(Console.ReadLine());
            string alerg;
            Console.WriteLine("Imate li neke alergije? (ako da, navedite ih)");
            alerg = Console.ReadLine();
            string bolest;
            Console.WriteLine("Da li ste ranije imali neke bolesti (ako da, navedite ih)");
            bolest = Console.ReadLine();
            string ZdravStanje;
            Console.WriteLine("Kakvo je opce zdravstveno stanje u vasoj porodici?");
            ZdravStanje = Console.ReadLine();
            Karton karton = new Karton(alerg, bolest, ZdravStanje);
            klinika17395_1.RegistrirajNoviKarton(id, karton);
        }
        private static void PacijentNaplataUsluga()
        {
            Console.WriteLine("Unesite id pacijenta: ");
            int id;
            id = Convert.ToInt32(Console.ReadLine());
            Pacijent p = klinika17395_1.DajPacijentaSaId(id);
            Console.WriteLine("Pacijent je obavio sljedece preglede:\n");
            Console.WriteLine(p.PrikaziObavljenePregledeSaCijenom());
            Console.WriteLine("Odaberite nacin placanja: 1. Gotovinsko placanje, 2. Placanje na rate\n");
            int izbor;
            decimal iznosNaplate;
            izbor = Convert.ToInt32(Console.ReadLine());
            if(izbor == 1)
            {
                iznosNaplate = klinika17395_1.ObracunajPacijenta(p, p.karton.obavljeniPregledi, 1);
                Console.WriteLine("Ukupna cijena: {0} KM\n", p.IznosNaplate());
            }
            else
            {
                Console.WriteLine("Placanje je moguce izvrsiti na 6, 12 ili 24 rate. Unesite broj rata: ");
                int brojRata;
                brojRata = Convert.ToInt32(Console.ReadLine());
                iznosNaplate = klinika17395_1.ObracunajPacijenta(p, p.karton.obavljeniPregledi, brojRata);
                Console.WriteLine("Potrebno je platiti prvu ratu odmah. Cijena: {0} KM\n", Math.Round(iznosNaplate / brojRata));
                Console.WriteLine("Preostali dug: {0}, broj rata: {1}, iznosa: {2} KM\n", Math.Round(iznosNaplate - iznosNaplate/brojRata, 3), brojRata - 1, Math.Round(iznosNaplate /brojRata)); 
            }
        }
        static void AnalizaSadrzaja()
        {
            string izbor;
            Console.WriteLine("1. Starosna struktura pacijenata\n2. Najposjecenije ordinacije\n3. Ukupna zarada\n");
            izbor = Console.ReadLine();
            switch (izbor)
            {
                case "1" :
                    Console.WriteLine(klinika17395_1.ProcenatPacijenataPoGodinama());
                    break;
                case "2" :
                    Console.WriteLine(klinika17395_1.NajposjecenijeOrdinacije());
                    break;
                case "3":
                    Console.WriteLine(klinika17395_1.IzvjestajZarada());
                    break;
                default:
                    break;
            }
        }
        static void OdjavnaPoruka()
        {
            Console.WriteLine("Doviđenja!");
            Environment.Exit(0);
        }
        static string IzracunajMD5Hash(string password)
        {
            MD5 md5 = MD5.Create();
            byte[] ulaz = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(ulaz);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        public delegate void funkcijaMeni(); // delegat na funckiju bez parametara i povratne vrijednosti

        static void Main(string[] args)
        {
            
            Osoba korisnik = null;
            string s, p;
            Console.WriteLine("Unesite login podatke\nusername: ");
            s = Console.ReadLine();
            Console.WriteLine("password: ");
            p = Console.ReadLine();

            List<funkcijaMeni> listaFunkcijaMeni = new List<funkcijaMeni>();

            foreach (Uposlenik u in klinika17395_1.uposlenici)
            {
                if(u.username == s && u.password == IzracunajMD5Hash(p))
                {
                    if (u is Doktor)
                    {
                        korisnik = u as Doktor;
                        listaFunkcijaMeni.Add(RegistracijaNovogPregleda);
                        listaFunkcijaMeni.Add(PacijentPretragaKartona);
                        listaFunkcijaMeni.Add(PacijentRasporedPregleda);
                    }
                    else
                    {
                        korisnik = u as Uposlenik;
                        listaFunkcijaMeni.Add(PacijentRegistracijaBrisanje);
                        listaFunkcijaMeni.Add(PacijentKreiranjeKartona);
                        listaFunkcijaMeni.Add(AnalizaSadrzaja);
                        listaFunkcijaMeni.Add(PacijentNaplataUsluga);
                        listaFunkcijaMeni.Add(PacijentRasporedPregleda);
                    }
                    break;
                }
            }
            if(korisnik == null)
            {
                Console.WriteLine("Korisnik ne postoji!");
                Environment.Exit(0);
            }
            listaFunkcijaMeni.Add(OdjavnaPoruka);    

            try
            { 
                int izbor;
                for (;;)
                {
                    glavniMeni(korisnik);
                    izbor = Convert.ToInt32(Console.ReadLine());
                    if (izbor < 1 || izbor > listaFunkcijaMeni.Count)
                        throw new Exception("Pogresan izbor");
                    listaFunkcijaMeni.ElementAt(izbor - 1)();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } 
    }
}
