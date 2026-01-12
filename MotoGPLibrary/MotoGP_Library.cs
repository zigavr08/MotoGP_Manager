using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoGPLibrary
{
    
    public class Motor
    {

        private int konjskihMoci;
        private int hitrost;
        public const int maxHitrost = 360;
        public string Model { get; set; }

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
        public Motor()
        {
            Model = "Neznan model!";
            KonjskihMoci = 0;
            MaxHitrost = 0;
        }

        public Motor(string model, int konjskihMoci, int hitrost)
        {
            Model = model;
            KonjskihMoci = konjskihMoci;
            MaxHitrost = hitrost;
        }

        public Motor(Motor motor)
        {
            Model = motor.Model;
            KonjskihMoci = motor.KonjskihMoci;
            MaxHitrost = motor.MaxHitrost;
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
            Priimek = voznik.Priimek;
            Starost= voznik.Starost;
        }

        ~Voznik()
        {
        }

    }

    public class MotoGP_Voznik : Voznik
    {
        public readonly int StevilkaMotorja;
        public static int StVoznikov = 0;

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

        public int HitrostMotorja
        {
            get
            {
                if (NovMotor != null) return NovMotor.MaxHitrost;
                return 0;
            }
        }

        public MotoGP_Voznik(string ime, string priimek, int starost, int stevilkaMotorja, string ekipa, Motor motor) : base(ime, priimek, starost) 
        {
            if (stevilkaMotorja > 99 || stevilkaMotorja < 1)
            {
                throw new Exception("Številka motorja mora biti med 1 in 99!");
            }

            StevilkaMotorja = stevilkaMotorja;
            Ekipa = ekipa;
            NovMotor = motor;
            TockeSezone =  0;
            StVoznikov++;
        }

        public static bool operator > (MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone > v2.TockeSezone;
        }
        public static bool operator < (MotoGP_Voznik v1, MotoGP_Voznik v2)
        {
            return v1.TockeSezone < v2.TockeSezone;
        }

        ~MotoGP_Voznik()
        {
            StVoznikov --;
        }
    }
}
