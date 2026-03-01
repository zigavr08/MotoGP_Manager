using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGPLibrary
{
    //Vmesnik
    public interface ITekmovalec
    {
        string Ime { get; set; }
        string Priimek { get; set; }
        string PraznujZmago();
    }
    public class Motor
    {
        //Lastnosti
        private int konjskihMoci;
        private int hitrost;
        public const int maxHitrost = 360; //CONST
        public string Model { get; set; }

        //Omejitev lastnosti
        public int KonjskihMoci
        {
            get { return konjskihMoci; }
            set
            {
                if (value > 300)
                {
                    throw new Exception("Motor ime preveč konjskih moči!");
                }

                konjskihMoci = value;
            }
        }

        //Omejitev lastnosti
        public int MaxHitrost
        {
            get { return hitrost; }
            set
            {
                if (value > maxHitrost)
                {
                    throw new Exception("Prehitro!");
                }

                hitrost = value;
            }
        }

        //Konstruktor
        public Motor()
        {
            Model = "Neznan model!";
            KonjskihMoci = 0;
            MaxHitrost = 0;
        }

        //Konstruktor
        public Motor(string model, int konjskihMoci, int hitrost)
        {
            Model = model;
            KonjskihMoci = konjskihMoci;
            MaxHitrost = hitrost;
        }

        //Konstruktor
        public Motor(Motor motor)
        {
            Model = motor.Model;
            KonjskihMoci = motor.KonjskihMoci;
            MaxHitrost = motor.MaxHitrost;
        }

        //Destruktor
        ~Motor()
        {
        }
    }

    public abstract class Voznik : ITekmovalec
    {
        // lastnosti
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

        //Omejitev lastnosti
        public int Starost
        {
            get { return starost; }
            set
            {
                if (value < 16)
                {
                    throw new Exception("Voznik je premlad!");
                }
                else if (value > 50)
                {
                    throw new Exception("Voznik je prestar!");
                }
                else
                {
                    starost = value;
                }
            }
        }
        //Abstraktna metoda
        public abstract string PraznujZmago();

        //Konstruktor
        public Voznik()
        {
            ime = "Ime neznano!";
            priimek = "Priimek neznan!";
            starost = 0;
        }

        //Konstruktor
        public Voznik(string ime, string priimek, int starost)
        {
            Ime = ime;
            Priimek = priimek;
            Starost = starost;
        }

        //Konstruktor
        public Voznik(Voznik voznik)
        {
            Ime = voznik.Ime;
            Priimek = voznik.Priimek;
            Starost = voznik.Starost;
        }

        //Destruktor
        ~Voznik()
        {
        }

    }

    public class MotoGP_Voznik : Voznik
    {
        // lastnosti
        public readonly int StevilkaMotorja; //READONLY
        public static int StVoznikov = 0; //STATIC
        public string Ekipa { get; set; }



        //DELEGAT IN DOGODEK
        public delegate void SpremembaTockDelegate(string sporocilo);
        public event SpremembaTockDelegate ObvestiloOTockah;

        //LASTNOST ZA TOČKE
        private int tockeSezone;
        public int TockeSezone
        {
            get { return tockeSezone; }
            set
            {
                int stareTocke = tockeSezone;
                tockeSezone = value;

                if (tockeSezone > stareTocke)
                {
                    ObvestiloOTockah("Voznik " + Ime + Priimek + " je dobil točke! Zdaj jih ima " + tockeSezone + ".");
                }
            }
        }





        // objekt v objektu (Poleg imena, priimka in starosti še vsebuje vse podatke iz classa Motor)
        // nerabim spet pisati lastnosi in omejitev iz prejšnega classa
        public Motor NovMotor { get; set; }

        //Indikserji
        private int[] rezultatiZadnjihDirk = new int[5];
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < rezultatiZadnjihDirk.Length)
                {
                    return rezultatiZadnjihDirk[index];
                }
                else
                {
                    return 0;
                }
            }

            set
            {
                if (index >= 0 && index < rezultatiZadnjihDirk.Length)
                {
                    rezultatiZadnjihDirk[index] = value;
                }
            }
        }

        //Polimerfizem
        public override string PraznujZmago()
        {
            return "Voznik " + Ime + Priimek + " odpira šampanjec in pozdravlja ekipo " + Ekipa + "!";
        }

        public string ModelMotorja
        {
            //Omejitev lastnosti
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

        //Omejitev lastnosti
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

        //Omejitev lastnosti
        public int HitrostMotorja
        {
            get
            {
                if (NovMotor != null)
                {
                    return NovMotor.MaxHitrost;

                }
                else
                {
                    return 0;
                }
            }
        }

        //Konstruktor
        public MotoGP_Voznik(string ime, string priimek, int starost, int stevilkaMotorja, string ekipa, Motor motor) : base(ime, priimek, starost)
        {

            //Omejitev lastnosti
            if (stevilkaMotorja > 99 || stevilkaMotorja < 1)
            {
                throw new Exception("Številka motorja mora biti med 1 in 99!");
            }

            StevilkaMotorja = stevilkaMotorja;
            Ekipa = ekipa;
            NovMotor = motor;
            TockeSezone = 0;
            StVoznikov++;
        }

        //PREOBLAGNAJE OPERATORJEV
        //Primerja kateri je voznik je boljši da lahko potem to izpiše v tabeli
        public static bool operator >(MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone > v2.TockeSezone;
        }
        public static bool operator <(MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone < v2.TockeSezone;
        }

        //Destruktor
        ~MotoGP_Voznik()
        {
            StVoznikov--;
        }
    }
}

