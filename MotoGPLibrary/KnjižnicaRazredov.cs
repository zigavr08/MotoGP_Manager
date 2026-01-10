using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGPLibrary
{
    
    public class Motor
    {
        public string Model { get; set; }
        public int KonjskihMoci { get; set; }

        public Motor()
        {
            Model = "Neznan model!";
            KonjskihMoci = 0;
        }

        public Motor(string model, int konjskihMoci)
        {
            Model = model;
            KonjskihMoci = konjskihMoci;
        }

        public Motor(Motor motor)
        {
            Model = motor.Model;
            KonjskihMoci = motor.KonjskihMoci;
        }

        ~Motor()
        {
        }
    }

    public abstract class Voznik
    {
        private string ime;
        private string priimek;
        private int starost;

        public string Ime
        {
            get { return ime; } 
            set { ime = value; }
        }

        public string Priimek
        {
            get { return priimek; }
            set { priimek = value; }
        }

        public int Starost
        {
            get { return starost; }
            set 
            {
                if (value < 16)
                {
                    throw new Exception("Voznik je premlad!");
                }
                else
                {
                    starost = value;
                }
            }
        }

        public Voznik()
        {
            ime = "Ime neznano!";
            priimek = "Priimek neznan!";
            starost = 0;
        }

        public Voznik (string ime, string priimek, int starost)
        {
            Ime = ime;
            Priimek = priimek;
            Starost = starost;
        }

        public Voznik (Voznik voznik)
        {
            Ime = voznik.Ime;
            Priimek = voznik.priimek;
            Starost= voznik.starost;
        }

        ~Voznik()
        {
        }

        public virtual string Izpis()
        {
            return ime + " " + priimek + ", " + starost + " let.";
        }
    }

    public class MotoGP_Voznik : Voznik
    {
        public readonly int StevilkaMotorja;
        public const int MaxHitrost = 360;

        public string Ekipa { get; set; }
        public int TockeSezone { get; set; }

        // objekt v objektu (Poleg imena, priimka in starosti se vsebuje vse podatke iz classa Motor)
        public Motor NovMotor { get; set; }

        public string ModelMotorja
        {
            get
            {
                if (NovMotor != null)
                {
                    return NovMotor.Model;
                }
                else
                {
                    return "Ni motorja";
                }
            }
        }

        public int MocMotorja
        {
            get
            {
                if (NovMotor != null)
                {
                    return NovMotor.KonjskihMoci;
                }
                else
                {
                    return 0;
                }
            }
        }
        public MotoGP_Voznik(string ime, string priimek, int starost, int stevilkaMotorja, string ekipa, Motor motor) : base(ime, priimek, starost) 
        {
            StevilkaMotorja = stevilkaMotorja;
            Ekipa = ekipa;
            NovMotor = motor;
            TockeSezone =  0;
        }

        public static bool operator > (MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone > v2.TockeSezone;
        }
        public static bool operator < (MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone < v2.TockeSezone;
        }
    }

    public class Dirka
    {
        public static int StVsehDirk = 0;

        public string ImeDirke { get; set; }
        public string Lokacija { get; set; }


        public Dirka ()
        {
            ImeDirke = "Neznano ime dirke!";
            Lokacija = "Neznana Lokacija!";
            StVsehDirk++;
        }

        public Dirka (string imeDirke, string lokacija)
        {
            ImeDirke = imeDirke;
            Lokacija = lokacija;
            StVsehDirk++;
        }

        public Dirka (Dirka dirka)
        {
            ImeDirke = dirka.ImeDirke;
            Lokacija = dirka.Lokacija;
            StVsehDirk++;
        }

        public static string Izpis()
        {
            return "Število dirk v sezoni: " + StVsehDirk + ".";
        }

        ~Dirka()
        {
        }

    }


}
