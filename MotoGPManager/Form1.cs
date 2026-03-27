using MotoGPLibrary;
namespace MotoGPManager
{
    /// <summary>
    /// Glavno okno aplikacije za upravljanje MotoGP dirkaèev in motorjev.
    /// Vsebuje logiko za vnos, prikaz, primerjavo in posodabljanje podatkov.
    /// </summary>
    public partial class Form1 : Form
    {
        //Ustavri prazen seznam
        List<MotoGP_Voznik> vsiVozniki = new List<MotoGP_Voznik>();
        //Zaèetek izvajanje(onemogoèeni doloèeni gumbi)
        /// <summary>
        /// Konstruktor obrazca, ki inicializira komponente in nastavi zaèetno stanje uporabniškega vmesnika.
        /// </summary>
        public Form1()
        {

            InitializeComponent();
            listView1.DoubleClick += listView1_DoubleClick;
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            buttonTocek.Enabled = false;
            buttonPrimerjaj.Enabled = false;
            buttonOdstrani.Enabled = false;
            buttonPoèisti.Enabled = false;
        }

        //GUMB DODAJ
        /// <summary>
        /// Odziv na klik gumba za dodajanje. Preveri vnose, ustvari ustrezen objekt (Voznik/MladiVoznik),
        /// naroèi se na dogodek obvešèanja o toèkah in osveži tabelo.
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            //Preverjanje sveh vnosnih polij
            if (textBoxIme.Text.Trim() == "" || textBoxPriimek.Text.Trim() == "" ||
                textBoxEkipa.Text.Trim() == "" || textBoxModel.Text.Trim() == "" ||
                numericUpDownStarost.Value == 0 || numericUpDownStMotorja.Value == 0 ||
                numericUpDownMoc.Value == 0)
            {
                MessageBox.Show("Izpolni vsa polja!");
                return;
            }
            else
            {
                buttonTocek.Enabled = true;
                buttonOdstrani.Enabled = true;
                buttonPoèisti.Enabled = true;
            }

            try
            {
                //dodajanje ime spremenlijvk in dodajenje njim vrednost
                string ime = textBoxIme.Text;
                string priimek = textBoxPriimek.Text;

                int starost = (int)numericUpDownStarost.Value;
                int stevilka = (int)numericUpDownStMotorja.Value;
                string ekipa = textBoxEkipa.Text;

                string model = textBoxModel.Text;
                int moc = (int)numericUpDownMoc.Value;
                int hitrost = (int)numericUpDownHitrost.Value;

                Motor novMotor = new Motor(model, moc, hitrost);

                //Preverja kaj sebo izpisalo(Polimerfizem)
                MotoGP_Voznik novVoznik;
                if (starost < 18)
                {
                    novVoznik = new MladiVoznik(ime, priimek, starost, stevilka, ekipa, novMotor);
                }
                else
                {
                    novVoznik = new MotoGP_Voznik(ime, priimek, starost, stevilka, ekipa, novMotor);
                }

                //DOGODEK
                novVoznik.ObvestiloOTockah += delegate (string sporocilo)
                {
                    MessageBox.Show(sporocilo, "Nova obvestila z dirkališèa");
                };              
                
                //dodajanje voznika v tabelo
                vsiVozniki.Add(novVoznik);
                OsveziTabelo();

                //Resetiranje vsek vnosnih polij
                textBoxIme.Clear();
                textBoxPriimek.Clear();
                textBoxEkipa.Clear();
                textBoxModel.Clear();


                numericUpDownStarost.Value = 0;
                numericUpDownStMotorja.Value = 0;
                numericUpDownMoc.Value = 0;
                numericUpDownHitrost.Value = 0;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        // GUMB ZA DODAJANJE TOÈK
        /// <summary>
        /// Metoda za dodajanje prvenstvenih toèk izbranemu dirkaèu. 
        /// Sprememba lastnosti TockeSezone sproži dogodek ObvestiloOTockah.
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            //Prevejranje ce je izbrana vrstica v tabeli za dodajanje toèk
            if (listView1.SelectedItems.Count > 0)
            {
                int index = listView1.SelectedIndices[0];

                if (index < vsiVozniki.Count)
                {
                    vsiVozniki[index].TockeSezone += 25;

                    OsveziTabelo();
                }
            }
            else
            {
                MessageBox.Show("Izberi voznika v tabeli!");
            }
        }

        //GUMB PRIMERJAJ
        /// <summary>
        /// Metoda za primerjavo prvih dveh dirkaèev v seznamu z uporabo preobremenjenih operatorjev.
        /// </summary>
        private void button3_Click(object sender, EventArgs e)
        {
            //Preverja da sta vsaj dva voznika v tabeli da ju lahko preverja
            if (vsiVozniki.Count >= 2)
            {
                if (vsiVozniki[0] > vsiVozniki[1])
                {
                    MessageBox.Show(vsiVozniki[0].PraznujZmago() + " Zmagovalec!");
                }
                else if (vsiVozniki[0] < vsiVozniki[1])
                {
                    MessageBox.Show(vsiVozniki[1].PraznujZmago() + " Zmagovalec!");
                }
                else
                {
                    MessageBox.Show("Izenaèeno!");
                }
            }
            else
            {
                MessageBox.Show("Dodaj vsaj 2 voznika!");
            }
        }

        //Metoda ki za vsako izvajanje gumba osveži tabelo da se podatki posodobijo
        /// <summary>
        /// Pomožna metoda, ki poèisti ListView in naloži posodobljene podatke iz seznama vseh voznikov.
        /// </summary>
        public void OsveziTabelo()
        {
            listView1.Items.Clear();

            foreach (var voznik in vsiVozniki)
            {
                //Naredi novo vrstico in vnese vse podatke
                ListViewItem vrstica = new ListViewItem(voznik.Ime);

                vrstica.SubItems.Add(voznik.Priimek);
                vrstica.SubItems.Add(voznik.Starost.ToString());
                vrstica.SubItems.Add(voznik.StevilkaMotorja.ToString());
                vrstica.SubItems.Add(voznik.Ekipa);
                vrstica.SubItems.Add(voznik.TockeSezone.ToString());
                vrstica.SubItems.Add(voznik.ModelMotorja);
                vrstica.SubItems.Add(voznik.MocMotorja.ToString() + " KM");
                vrstica.SubItems.Add(voznik.HitrostMotorja.ToString() + " km/h");

                listView1.Items.Add(vrstica);

                //Prevrja èe sta dva voznika v tabeli
                //Èe nista gumb Primrjaj ni na voljo
                if (vsiVozniki.Count >= 2)
                {
                    buttonPrimerjaj.Enabled = true;
                }
                else
                {
                    buttonPrimerjaj.Enabled = false;
                }
            }
            //Izpisovanje v label št. voznikov
            label10.Text = "Število voznikov: " + MotoGP_Voznik.StVoznikov.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Onemogoèeno vstavljanje številk v textbox
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Onemogoèeno vstavljanje številk v textbox
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Onemogoèeno vstavljanje številk v textbox
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //GUMB ODSTRANI
        /// <summary>
        /// Odstrani izbranega voznika iz seznama in posodobi statièno števec voznikov.
        /// </summary>
        private void button5_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                vsiVozniki.RemoveAt(index);
                MotoGP_Voznik.StVoznikov--;
                OsveziTabelo();
            }
            else
            {
                MessageBox.Show("Najprej oznaèi voznika, ki ga želiš izbrisati!");
            }
        }

        //GUMB ZA POÈISTITI TABELO
        private void button6_Click(object sender, EventArgs e)
        {
            vsiVozniki.Clear();
            MotoGP_Voznik.StVoznikov = 0;
            OsveziTabelo();
            MessageBox.Show("Vsi podatki so bili izbrisani.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void numericUpDownStarost_ValueChanged(object sender, EventArgs e)
        {

        }
        // DVOJNI KLIK NA TABELO ZA IZPIS PODATKOV (INDEKSER)
        /// <summary>
        /// Odziv na dogodek dvojnega klika na vrstico v tabeli. 
        /// Preko indekserja pridobi podatke o vozniku in jih prikaže v osebni karton.
        /// </summary>
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                int index = listView1.SelectedIndices[0];
                MotoGP_Voznik izbrani = vsiVozniki[index];

                string izpis = "PODATKI O VOZNIKU:\n\n" +
                               "Ime in priimek: " + izbrani["ime"] + " " + izbrani["priimek"] + "\n" +
                               "Starost: " + izbrani["starost"] + "\n" +
                               "Ekipa: " + izbrani["ekipa"] + "\n" +
                               "Motor: " + izbrani["motor"];

                MessageBox.Show(izpis, "Osebni karton voznika");
            }
        }
    }
}

