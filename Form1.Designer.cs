namespace mulasztasokGUI
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
            label1 = new Label();
            rradatok = new RichTextBox();
            dgadatok = new DataGridView();
            nev = new DataGridViewTextBoxColumn();
            osztaly = new DataGridViewTextBoxColumn();
            hanyadikan = new DataGridViewTextBoxColumn();
            igazolt = new DataGridViewTextBoxColumn();
            nemigazolt = new DataGridViewTextBoxColumn();
            osszeshianyzas = new DataGridViewTextBoxColumn();
            label2 = new Label();
            txnev = new TextBox();
            label3 = new Label();
            txosztaly = new TextBox();
            label4 = new Label();
            cbhanyadika = new ComboBox();
            label5 = new Label();
            txigazolt = new TextBox();
            label6 = new Label();
            txnemigazolt = new TextBox();
            lbosszes = new Label();
            lblegtobb = new Label();
            lborakszama = new Label();
            btmentes = new Button();
            label7 = new Label();
            rrtanulok = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dgadatok).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Adatok";
            // 
            // rradatok
            // 
            rradatok.Location = new Point(12, 48);
            rradatok.Name = "rradatok";
            rradatok.ReadOnly = true;
            rradatok.Size = new Size(832, 196);
            rradatok.TabIndex = 1;
            rradatok.Text = "";
            // 
            // dgadatok
            // 
            dgadatok.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgadatok.Columns.AddRange(new DataGridViewColumn[] { nev, osztaly, hanyadikan, igazolt, nemigazolt, osszeshianyzas });
            dgadatok.Location = new Point(12, 261);
            dgadatok.Name = "dgadatok";
            dgadatok.RowHeadersWidth = 51;
            dgadatok.Size = new Size(830, 357);
            dgadatok.TabIndex = 2;
            // 
            // nev
            // 
            nev.HeaderText = "Név";
            nev.MinimumWidth = 6;
            nev.Name = "nev";
            nev.ReadOnly = true;
            nev.Width = 150;
            // 
            // osztaly
            // 
            osztaly.HeaderText = "Osztály";
            osztaly.MinimumWidth = 6;
            osztaly.Name = "osztaly";
            osztaly.ReadOnly = true;
            osztaly.Width = 125;
            // 
            // hanyadikan
            // 
            hanyadikan.HeaderText = "Hányadikán";
            hanyadikan.MinimumWidth = 6;
            hanyadikan.Name = "hanyadikan";
            hanyadikan.ReadOnly = true;
            hanyadikan.Width = 125;
            // 
            // igazolt
            // 
            igazolt.HeaderText = "Igazolt";
            igazolt.MinimumWidth = 6;
            igazolt.Name = "igazolt";
            igazolt.ReadOnly = true;
            igazolt.Width = 125;
            // 
            // nemigazolt
            // 
            nemigazolt.HeaderText = "Nem igazolt";
            nemigazolt.MinimumWidth = 6;
            nemigazolt.Name = "nemigazolt";
            nemigazolt.ReadOnly = true;
            nemigazolt.Width = 125;
            // 
            // osszeshianyzas
            // 
            osszeshianyzas.HeaderText = "Összes hiányzás";
            osszeshianyzas.MinimumWidth = 6;
            osszeshianyzas.Name = "osszeshianyzas";
            osszeshianyzas.ReadOnly = true;
            osszeshianyzas.Width = 125;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(849, 51);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 3;
            label2.Text = "Név:";
            // 
            // txnev
            // 
            txnev.Location = new Point(896, 48);
            txnev.Name = "txnev";
            txnev.Size = new Size(235, 27);
            txnev.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(849, 106);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 5;
            label3.Text = "Osztály:";
            // 
            // txosztaly
            // 
            txosztaly.Location = new Point(919, 103);
            txosztaly.Name = "txosztaly";
            txosztaly.Size = new Size(100, 27);
            txosztaly.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(849, 156);
            label4.Name = "label4";
            label4.Size = new Size(95, 20);
            label4.TabIndex = 7;
            label4.Text = "Hányadikán:";
            // 
            // cbhanyadika
            // 
            cbhanyadika.DropDownStyle = ComboBoxStyle.DropDownList;
            cbhanyadika.FormattingEnabled = true;
            cbhanyadika.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cbhanyadika.Location = new Point(950, 153);
            cbhanyadika.Name = "cbhanyadika";
            cbhanyadika.Size = new Size(82, 28);
            cbhanyadika.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(849, 220);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 9;
            label5.Text = "Igazolt:";
            // 
            // txigazolt
            // 
            txigazolt.Location = new Point(916, 217);
            txigazolt.Name = "txigazolt";
            txigazolt.Size = new Size(91, 27);
            txigazolt.TabIndex = 10;
            txigazolt.TextChanged += txigazolt_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(849, 268);
            label6.Name = "label6";
            label6.Size = new Size(98, 20);
            label6.TabIndex = 11;
            label6.Text = "Nem igazolt:";
            // 
            // txnemigazolt
            // 
            txnemigazolt.Location = new Point(953, 265);
            txnemigazolt.Name = "txnemigazolt";
            txnemigazolt.Size = new Size(88, 27);
            txnemigazolt.TabIndex = 12;
            txnemigazolt.TextChanged += txnemigazolt_TextChanged;
            // 
            // lbosszes
            // 
            lbosszes.AutoSize = true;
            lbosszes.Location = new Point(849, 316);
            lbosszes.Name = "lbosszes";
            lbosszes.Size = new Size(222, 20);
            lbosszes.TabIndex = 13;
            lbosszes.Text = "Összes hiányzása adott napon:";
            // 
            // lblegtobb
            // 
            lblegtobb.AutoSize = true;
            lblegtobb.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblegtobb.ForeColor = Color.Red;
            lblegtobb.Location = new Point(896, 391);
            lblegtobb.Name = "lblegtobb";
            lblegtobb.Size = new Size(167, 25);
            lblegtobb.TabIndex = 14;
            lblegtobb.Text = "Legtöbb hiányzás";
            // 
            // lborakszama
            // 
            lborakszama.AutoSize = true;
            lborakszama.Location = new Point(896, 442);
            lborakszama.Name = "lborakszama";
            lborakszama.Size = new Size(94, 20);
            lborakszama.TabIndex = 15;
            lborakszama.Text = "Órák száma:";
            // 
            // btmentes
            // 
            btmentes.Location = new Point(1093, 89);
            btmentes.Name = "btmentes";
            btmentes.Size = new Size(183, 203);
            btmentes.TabIndex = 16;
            btmentes.Text = "Mentés";
            btmentes.UseVisualStyleBackColor = true;
            btmentes.Click += btmentes_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1062, 469);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 17;
            label7.Text = "Tanulók:";
            // 
            // rrtanulok
            // 
            rrtanulok.Location = new Point(1065, 492);
            rrtanulok.Name = "rrtanulok";
            rrtanulok.ReadOnly = true;
            rrtanulok.Size = new Size(188, 120);
            rrtanulok.TabIndex = 18;
            rrtanulok.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 630);
            Controls.Add(rrtanulok);
            Controls.Add(label7);
            Controls.Add(btmentes);
            Controls.Add(lborakszama);
            Controls.Add(lblegtobb);
            Controls.Add(lbosszes);
            Controls.Add(txnemigazolt);
            Controls.Add(label6);
            Controls.Add(txigazolt);
            Controls.Add(label5);
            Controls.Add(cbhanyadika);
            Controls.Add(label4);
            Controls.Add(txosztaly);
            Controls.Add(label3);
            Controls.Add(txnev);
            Controls.Add(label2);
            Controls.Add(dgadatok);
            Controls.Add(rradatok);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Text = "Mulaszások - szeptember hónapban";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgadatok).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rradatok;
        private DataGridView dgadatok;
        private DataGridViewTextBoxColumn nev;
        private DataGridViewTextBoxColumn osztaly;
        private DataGridViewTextBoxColumn hanyadikan;
        private DataGridViewTextBoxColumn igazolt;
        private DataGridViewTextBoxColumn nemigazolt;
        private DataGridViewTextBoxColumn osszeshianyzas;
        private Label label2;
        private TextBox txnev;
        private Label label3;
        private TextBox txosztaly;
        private Label label4;
        private ComboBox cbhanyadika;
        private Label label5;
        private TextBox txigazolt;
        private Label label6;
        private TextBox txnemigazolt;
        private Label lbosszes;
        private Label lblegtobb;
        private Label lborakszama;
        private Button btmentes;
        private Label label7;
        private RichTextBox rrtanulok;
    }
}
