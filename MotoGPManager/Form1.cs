using MotoGPLibrary;
namespace MotoGPManager
{
    public partial class Form1 : Form
    {
        List<MotoGP_Voznik> vsiVozniki = new List<MotoGP_Voznik>();
        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            buttonTocek.Enabled = false;
            buttonPrimerjaj.Enabled = false;
            buttonOdtarni.Enabled = false;
            buttonPoèisti.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
                buttonOdtarni.Enabled = true;
                buttonPoèisti.Enabled = true;
            }

            try
            {
                string ime = textBoxIme.Text;
                string priimek = textBoxPriimek.Text;

                int starost = (int)numericUpDownStarost.Value;
                int stevilka = (int)numericUpDownStMotorja.Value;
                string ekipa = textBoxEkipa.Text;

                string model = textBoxModel.Text;
                int moc = (int)numericUpDownMoc.Value;
                int hitrost = (int)numericUpDownHitrost.Value;

                Motor novMotor = new Motor(model, moc, hitrost);
                MotoGP_Voznik novVoznik = new MotoGP_Voznik(ime, priimek, starost, stevilka, ekipa,  novMotor);

                vsiVozniki.Add(novVoznik);
                OsveziTabelo();

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

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (vsiVozniki.Count >= 2)
            {
                if (vsiVozniki[0] > vsiVozniki[1])
                {
                    MessageBox.Show(vsiVozniki[0].Ime + " vodi!");
                }
                else if (vsiVozniki[0] < vsiVozniki[1])
                {
                    MessageBox.Show(vsiVozniki[1].Ime + " vodi!");
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

        public void OsveziTabelo()
        {
            listView1.Items.Clear();

            foreach (var voznik in vsiVozniki)
            {
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

                if (vsiVozniki.Count >= 2)
                {
                    buttonPrimerjaj.Enabled = true;
                }
                else
                {
                    buttonPrimerjaj.Enabled = false;
                }
            }
                label10.Text = "Število voznikov: " + MotoGP_Voznik.StVoznikov.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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

        private void button6_Click(object sender, EventArgs e)
        {
            vsiVozniki.Clear();
            MotoGP_Voznik.StVoznikov = 0;
            OsveziTabelo();
            MessageBox.Show("Vsi podatki so bili izbrisani.");
        }
    }
}
