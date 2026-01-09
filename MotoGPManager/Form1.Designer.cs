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
            textBox2 = new TextBox();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            ime = new DataGridViewTextBoxColumn();
            starost = new DataGridViewTextBoxColumn();
            ekipa = new DataGridViewTextBoxColumn();
            tockeSezone = new DataGridViewTextBoxColumn();
            modelMotorja = new DataGridViewTextBoxColumn();
            mocMotorja = new DataGridViewTextBoxColumn();
            label7 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 168);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Podatki o vozniku";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 23);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 107);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "Ekipa:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(186, 81);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(13, 81);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 63);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 3;
            label3.Text = "Štartna številka:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 63);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Starost:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 1;
            label1.Text = "Ime in priimek:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(295, 23);
            textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Location = new Point(334, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 168);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Motor";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(13, 81);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(120, 23);
            numericUpDown3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 63);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 1;
            label6.Text = "Moč";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 19);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 2;
            label5.Text = "Mode motorja:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(11, 37);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(295, 23);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 186);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 1;
            button1.Text = "Dodaj voznika";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ime, starost, ekipa, tockeSezone, modelMotorja, mocMotorja });
            dataGridView1.Location = new Point(12, 237);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(637, 194);
            dataGridView1.TabIndex = 2;
            // 
            // ime
            // 
            ime.HeaderText = "Ime";
            ime.Name = "ime";
            ime.ReadOnly = true;
            // 
            // starost
            // 
            starost.HeaderText = "Starost";
            starost.Name = "starost";
            starost.ReadOnly = true;
            // 
            // ekipa
            // 
            ekipa.HeaderText = "Ekipa";
            ekipa.Name = "ekipa";
            ekipa.ReadOnly = true;
            // 
            // tockeSezone
            // 
            tockeSezone.HeaderText = "Točke Sezone";
            tockeSezone.Name = "tockeSezone";
            tockeSezone.ReadOnly = true;
            // 
            // modelMotorja
            // 
            modelMotorja.HeaderText = "Model motorja";
            modelMotorja.Name = "modelMotorja";
            modelMotorja.ReadOnly = true;
            // 
            // mocMotorja
            // 
            mocMotorja.HeaderText = "Moč motorja";
            mocMotorja.Name = "mocMotorja";
            mocMotorja.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 219);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 3;
            label7.Text = "Seznam voznikov:";
            // 
            // button2
            // 
            button2.Location = new Point(12, 449);
            button2.Name = "button2";
            button2.Size = new Size(115, 23);
            button2.TabIndex = 4;
            button2.Text = "Dodaj točke (+25)";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(182, 449);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Primerjaj";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(303, 449);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 6;
            button4.Text = "Nova dirka";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 484);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "MotoGP Manager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private NumericUpDown numericUpDown3;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn ime;
        private DataGridViewTextBoxColumn starost;
        private DataGridViewTextBoxColumn ekipa;
        private DataGridViewTextBoxColumn tockeSezone;
        private DataGridViewTextBoxColumn modelMotorja;
        private DataGridViewTextBoxColumn mocMotorja;
    }
}
