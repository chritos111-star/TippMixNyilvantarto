namespace TippMixNyilvantarto
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKapcsolat = new System.Windows.Forms.Button();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnTorles = new System.Windows.Forms.Button();
            this.btnModosit = new System.Windows.Forms.Button();
            this.cmBoxTipp = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textTet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOdds = new System.Windows.Forms.TextBox();
            this.txtHazaiId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVendegId = new System.Windows.Forms.TextBox();
            this.btncsapathozzaad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBttsOdds = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKapcsolat
            // 
            this.btnKapcsolat.Location = new System.Drawing.Point(713, 12);
            this.btnKapcsolat.Name = "btnKapcsolat";
            this.btnKapcsolat.Size = new System.Drawing.Size(75, 23);
            this.btnKapcsolat.TabIndex = 0;
            this.btnKapcsolat.Text = "Kapcsolat teszt";
            this.btnKapcsolat.UseVisualStyleBackColor = true;
            this.btnKapcsolat.Click += new System.EventHandler(this.btnKapcsolat_Click);
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(89, 12);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(207, 20);
            this.txtNev.TabIndex = 1;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(89, 56);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(207, 20);
            this.txtOrszag.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Csapat neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ország:";
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(89, 337);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(75, 23);
            this.btnHozzaad.TabIndex = 5;
            this.btnHozzaad.Text = "Hozzáadás";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(386, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(321, 308);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(201, 337);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 23);
            this.btnLista.TabIndex = 7;
            this.btnLista.Text = "Listázás";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnTorles
            // 
            this.btnTorles.Location = new System.Drawing.Point(431, 389);
            this.btnTorles.Name = "btnTorles";
            this.btnTorles.Size = new System.Drawing.Size(75, 23);
            this.btnTorles.TabIndex = 8;
            this.btnTorles.Text = "Törlés";
            this.btnTorles.UseVisualStyleBackColor = true;
            this.btnTorles.Click += new System.EventHandler(this.btnTorles_Click);
            // 
            // btnModosit
            // 
            this.btnModosit.Location = new System.Drawing.Point(562, 388);
            this.btnModosit.Name = "btnModosit";
            this.btnModosit.Size = new System.Drawing.Size(75, 23);
            this.btnModosit.TabIndex = 9;
            this.btnModosit.Text = "Módosítás";
            this.btnModosit.UseVisualStyleBackColor = true;
            this.btnModosit.Click += new System.EventHandler(this.btnModosit_Click);
            // 
            // cmBoxTipp
            // 
            this.cmBoxTipp.FormattingEnabled = true;
            this.cmBoxTipp.Location = new System.Drawing.Point(89, 231);
            this.cmBoxTipp.Name = "cmBoxTipp";
            this.cmBoxTipp.Size = new System.Drawing.Size(207, 21);
            this.cmBoxTipp.TabIndex = 10;
            this.cmBoxTipp.SelectedIndexChanged += new System.EventHandler(this.cmBoxTipp_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(89, 313);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(152, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Mindkét csapat szerez gólt";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textTet
            // 
            this.textTet.Location = new System.Drawing.Point(89, 366);
            this.textTet.Name = "textTet";
            this.textTet.Size = new System.Drawing.Size(100, 20);
            this.textTet.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tét:";
            // 
            // btnSzamol
            // 
            this.btnSzamol.Location = new System.Drawing.Point(89, 405);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 14;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nyeremémy:";
            // 
            // txtOdds
            // 
            this.txtOdds.Location = new System.Drawing.Point(89, 198);
            this.txtOdds.Name = "txtOdds";
            this.txtOdds.Size = new System.Drawing.Size(100, 20);
            this.txtOdds.TabIndex = 16;
            // 
            // txtHazaiId
            // 
            this.txtHazaiId.Location = new System.Drawing.Point(89, 119);
            this.txtHazaiId.Name = "txtHazaiId";
            this.txtHazaiId.Size = new System.Drawing.Size(207, 20);
            this.txtHazaiId.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Odds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Hazai csapatId";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Vendég csapatId";
            // 
            // txtVendegId
            // 
            this.txtVendegId.Location = new System.Drawing.Point(89, 155);
            this.txtVendegId.Name = "txtVendegId";
            this.txtVendegId.Size = new System.Drawing.Size(207, 20);
            this.txtVendegId.TabIndex = 21;
            // 
            // btncsapathozzaad
            // 
            this.btncsapathozzaad.Location = new System.Drawing.Point(120, 90);
            this.btncsapathozzaad.Name = "btncsapathozzaad";
            this.btncsapathozzaad.Size = new System.Drawing.Size(143, 23);
            this.btncsapathozzaad.TabIndex = 22;
            this.btncsapathozzaad.Text = "Csapat hozzáadás";
            this.btncsapathozzaad.UseVisualStyleBackColor = true;
            this.btncsapathozzaad.Click += new System.EventHandler(this.btncsapathozzaad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "BTTS Odds:";
            // 
            // txtBttsOdds
            // 
            this.txtBttsOdds.Location = new System.Drawing.Point(89, 283);
            this.txtBttsOdds.Name = "txtBttsOdds";
            this.txtBttsOdds.Size = new System.Drawing.Size(100, 20);
            this.txtBttsOdds.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBttsOdds);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btncsapathozzaad);
            this.Controls.Add(this.txtVendegId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHazaiId);
            this.Controls.Add(this.txtOdds);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textTet);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cmBoxTipp);
            this.Controls.Add(this.btnModosit);
            this.Controls.Add(this.btnTorles);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnHozzaad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.btnKapcsolat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapcsolat;
        private System.Windows.Forms.TextBox txtNev;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnTorles;
        private System.Windows.Forms.Button btnModosit;
        private System.Windows.Forms.ComboBox cmBoxTipp;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textTet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOdds;
        private System.Windows.Forms.TextBox txtHazaiId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVendegId;
        private System.Windows.Forms.Button btncsapathozzaad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBttsOdds;
    }
}

