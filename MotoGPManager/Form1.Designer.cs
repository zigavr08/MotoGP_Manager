namespace MotoGPManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            label8 = new Label();
            textBoxPriimek = new TextBox();
            textBoxEkipa = new TextBox();
            label4 = new Label();
            numericUpDownStMotorja = new NumericUpDown();
            numericUpDownStarost = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxIme = new TextBox();
            groupBox2 = new GroupBox();
            label9 = new Label();
            numericUpDownHitrost = new NumericUpDown();
            numericUpDownMoc = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            textBoxModel = new TextBox();
            buttonDodaj = new Button();
            label7 = new Label();
            buttonTocek = new Button();
            buttonPrimerjaj = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            buttonOdstrani = new Button();
            buttonPočisti = new Button();
            label10 = new Label();
            button = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStMotorja).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStarost).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitrost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoc).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(textBoxPriimek);
            groupBox1.Controls.Add(textBoxEkipa);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDownStMotorja);
            groupBox1.Controls.Add(numericUpDownStarost);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxIme);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(422, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podatki o vozniku";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(224, 19);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 6;
            label8.Text = "Priimek:";
            // 
            // textBoxPriimek
            // 
            textBoxPriimek.Location = new Point(224, 37);
            textBoxPriimek.Name = "textBoxPriimek";
            textBoxPriimek.Size = new Size(192, 23);
            textBoxPriimek.TabIndex = 1;
            textBoxPriimek.KeyPress += textBox4_KeyPress;
            // 
            // textBoxEkipa
            // 
            textBoxEkipa.Location = new Point(11, 125);
            textBoxEkipa.Name = "textBoxEkipa";
            textBoxEkipa.Size = new Size(405, 23);
            textBoxEkipa.TabIndex = 4;
            textBoxEkipa.KeyPress += textBox2_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 107);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 9;
            label4.Text = "Ekipa:";
            // 
            // numericUpDownStMotorja
            // 
            numericUpDownStMotorja.Location = new Point(296, 81);
            numericUpDownStMotorja.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numericUpDownStMotorja.Name = "numericUpDownStMotorja";
            numericUpDownStMotorja.Size = new Size(120, 23);
            numericUpDownStMotorja.TabIndex = 3;
            // 
            // numericUpDownStarost
            // 
            numericUpDownStarost.Location = new Point(13, 81);
            numericUpDownStarost.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDownStarost.Name = "numericUpDownStarost";
            numericUpDownStarost.Size = new Size(120, 23);
            numericUpDownStarost.TabIndex = 2;
            numericUpDownStarost.ValueChanged += numericUpDownStarost_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(296, 63);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 8;
            label3.Text = "Številka motorja:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 7;
            label2.Text = "Starost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 5;
            label1.Text = "Ime:";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(11, 37);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(192, 23);
            textBoxIme.TabIndex = 0;
            textBoxIme.KeyPress += textBox1_KeyPress;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(numericUpDownHitrost);
            groupBox2.Controls.Add(numericUpDownMoc);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBoxModel);
            groupBox2.Location = new Point(515, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(422, 168);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Motor";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 63);
            label9.Name = "label9";
            label9.Size = new Size(108, 15);
            label9.TabIndex = 5;
            label9.Text = "Maksimalna hitrost";
            // 
            // numericUpDownHitrost
            // 
            numericUpDownHitrost.Location = new Point(296, 81);
            numericUpDownHitrost.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDownHitrost.Name = "numericUpDownHitrost";
            numericUpDownHitrost.Size = new Size(120, 23);
            numericUpDownHitrost.TabIndex = 2;
            // 
            // numericUpDownMoc
            // 
            numericUpDownMoc.Location = new Point(13, 81);
            numericUpDownMoc.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numericUpDownMoc.Name = "numericUpDownMoc";
            numericUpDownMoc.Size = new Size(120, 23);
            numericUpDownMoc.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 63);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 4;
            label6.Text = "Konjske moči:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 3;
            label5.Text = "Model motorja:";
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(11, 37);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(405, 23);
            textBoxModel.TabIndex = 0;
            // 
            // buttonDodaj
            // 
            buttonDodaj.Location = new Point(25, 186);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(106, 23);
            buttonDodaj.TabIndex = 2;
            buttonDodaj.Text = "&Dodaj voznika";
            buttonDodaj.UseVisualStyleBackColor = true;
            buttonDodaj.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 219);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 9;
            label7.Text = "Seznam voznikov:";
            // 
            // buttonTocek
            // 
            buttonTocek.Location = new Point(25, 449);
            buttonTocek.Name = "buttonTocek";
            buttonTocek.Size = new Size(142, 23);
            buttonTocek.TabIndex = 3;
            buttonTocek.Text = "Dodaj točke (+25)";
            buttonTocek.UseVisualStyleBackColor = true;
            buttonTocek.Click += button2_Click;
            // 
            // buttonPrimerjaj
            // 
            buttonPrimerjaj.Location = new Point(173, 449);
            buttonPrimerjaj.Name = "buttonPrimerjaj";
            buttonPrimerjaj.Size = new Size(142, 23);
            buttonPrimerjaj.TabIndex = 6;
            buttonPrimerjaj.Text = "Primerjaj";
            buttonPrimerjaj.UseVisualStyleBackColor = true;
            buttonPrimerjaj.Click += button3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader3, columnHeader10 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(19, 237);
            listView1.Name = "listView1";
            listView1.Scrollable = false;
            listView1.Size = new Size(918, 191);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ime";
            columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Priimek";
            columnHeader2.Width = 88;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Starost";
            columnHeader4.Width = 88;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Številka motorja";
            columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Ekipa";
            columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Točke sezone";
            columnHeader7.Width = 88;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Model motorja";
            columnHeader8.Width = 88;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Moč motorja";
            columnHeader9.Width = 88;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Maximalna hitrost";
            columnHeader3.Width = 110;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Rezultati";
            columnHeader10.Width = 110;
            // 
            // buttonOdstrani
            // 
            buttonOdstrani.Location = new Point(647, 449);
            buttonOdstrani.Name = "buttonOdstrani";
            buttonOdstrani.Size = new Size(142, 23);
            buttonOdstrani.TabIndex = 4;
            buttonOdstrani.Text = "&Odstrani dirkača";
            buttonOdstrani.UseVisualStyleBackColor = true;
            buttonOdstrani.Click += button5_Click;
            // 
            // buttonPočisti
            // 
            buttonPočisti.Location = new Point(795, 449);
            buttonPočisti.Name = "buttonPočisti";
            buttonPočisti.Size = new Size(142, 23);
            buttonPočisti.TabIndex = 5;
            buttonPočisti.Text = "&Počisti tabelo";
            buttonPočisti.UseVisualStyleBackColor = true;
            buttonPočisti.Click += button6_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(842, 219);
            label10.Name = "label10";
            label10.Size = new Size(95, 15);
            label10.TabIndex = 10;
            label10.Text = "Število voznikov:";
            // 
            // button
            // 
            button.Location = new Point(332, 186);
            button.Name = "button";
            button.Size = new Size(115, 23);
            button.TabIndex = 11;
            button.Text = "Simuliraj Sezono";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click_2;
            // 
            // Form1
            // 
            AcceptButton = buttonDodaj;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = buttonOdstrani;
            ClientSize = new Size(953, 486);
            Controls.Add(button);
            Controls.Add(label10);
            Controls.Add(buttonPočisti);
            Controls.Add(buttonOdstrani);
            Controls.Add(listView1);
            Controls.Add(buttonPrimerjaj);
            Controls.Add(buttonTocek);
            Controls.Add(label7);
            Controls.Add(buttonDodaj);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(969, 525);
            MinimumSize = new Size(969, 525);
            Name = "Form1";
            Text = "MotoGP Manager";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStMotorja).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStarost).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHitrost).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBoxIme;
        private GroupBox groupBox2;
        private TextBox textBoxEkipa;
        private Label label4;
        private NumericUpDown numericUpDownStMotorja;
        private NumericUpDown numericUpDownStarost;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownMoc;
        private Button buttonDodaj;
        private Label label7;
        private Button buttonTocek;
        private Button buttonPrimerjaj;
        private Label label8;
        private TextBox textBoxPriimek;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private Label label9;
        private NumericUpDown numericUpDownHitrost;
        private ColumnHeader columnHeader3;
        private TextBox textBoxModel;
        private Button buttonOdstrani;
        private Button buttonPočisti;
        private Label label10;
        private Button button;
        private ColumnHeader columnHeader10;
    }
}
