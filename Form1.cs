namespace mulasztasokGUI
{
    public partial class Form1 : Form
    {
        List<Mulasztas> lista = new List<Mulasztas>();
        string elsosor;
        void betoltes()
        {
            lista.Clear();
            dgadatok.Rows.Clear();
            FileStream fs = new FileStream("szeptember.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                Mulasztas m = new Mulasztas(sor);
                lista.Add(m);
                dgadatok.Rows.Add(m.Nev, m.Osztaly, m.Hanyadika, m.Igazolt, m.Nemigazolt, m.NapiHianyzasSzamolas().ToString());
                rradatok.Text = rradatok.Text + sor + "\n";
            }
            sr.Close();
            fs.Close();
            int max = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].NapiHianyzasSzamolas() > lista[max].NapiHianyzasSzamolas())
                {
                    max = i;
                }
            }
            lborakszama.Text = "�r�k sz�ma: " + lista[max].NapiHianyzasSzamolas().ToString();
            rrtanulok.Text = lista[max].Nev;
        }
        void szamolas()
        {
            if (txigazolt.TextLength > 0 && txnemigazolt.TextLength > 0)
            {
                int szamolas = Convert.ToInt32(txigazolt.Text) + Convert.ToInt32(txnemigazolt.Text);
                lbosszes.Text = "�sszes hi�nyz�s adott napon: " + szamolas.ToString();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            betoltes();
        }

        private void txigazolt_TextChanged(object sender, EventArgs e)
        {
            if (txigazolt.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txigazolt.Text);
                    szamolas();
                }
                catch
                {
                    MessageBox.Show("Eg�sz sz�mot adjon meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txigazolt.Clear();
                    txigazolt.Focus();
                }
            }
        }

        private void txnemigazolt_TextChanged(object sender, EventArgs e)
        {
            if (txnemigazolt.TextLength > 0)
            {
                try
                {
                    int szam = Convert.ToInt32(txnemigazolt.Text);
                    szamolas();
                }
                catch
                {
                    MessageBox.Show("Eg�sz sz�mot adjon meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txnemigazolt.Clear();
                    txnemigazolt.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("K�rem adja meg a tanul� nev�t!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if (txosztaly.TextLength == 0)
            {
                MessageBox.Show("K�rem adja meg a tanul� oszt�ly�t!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txosztaly.Focus();
            }
            else if (cbhanyadika.SelectedItem == null)
            {
                MessageBox.Show("K�rem adja meg, hogy h�nyadik�n volt!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbhanyadika.Focus();
            }
            else if (txigazolt.TextLength == 0)
            {
                MessageBox.Show("K�rem adja meg a tanul� igazolt hi�nyz�s�t!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txigazolt.Focus();
            }
            else if (txnemigazolt.TextLength == 0)
            {
                MessageBox.Show("K�rem adja meg a tanul� nem igazolt hi�nyz�s�t!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnemigazolt.Focus();
            }
            else
            {
                FileStream fs = new FileStream("szeptember.txt", FileMode.Append);
                StreamWriter sw = new StreamWriter(fs);
                sw.Write("\n" + txnev.Text + ";" + txosztaly.Text + ";" + cbhanyadika.SelectedItem + ";" + txigazolt.Text + ";" + txnemigazolt.Text);
                sw.Close();
                fs.Close();
                txnev.Clear();
                txosztaly.Clear();
                cbhanyadika.SelectedItem = null;
                txigazolt.Clear();
                txnemigazolt.Clear();
                betoltes();
            }
        }
    }
}
