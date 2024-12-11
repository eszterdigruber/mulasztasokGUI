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
            lborakszama.Text = "Órák száma: " + lista[max].NapiHianyzasSzamolas().ToString();
            rrtanulok.Text = lista[max].Nev;
        }
        void szamolas()
        {
            if (txigazolt.TextLength > 0 && txnemigazolt.TextLength > 0)
            {
                int szamolas = Convert.ToInt32(txigazolt.Text) + Convert.ToInt32(txnemigazolt.Text);
                lbosszes.Text = "Összes hiányzás adott napon: " + szamolas.ToString();
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
                    MessageBox.Show("Egész számot adjon meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Egész számot adjon meg!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txnemigazolt.Clear();
                    txnemigazolt.Focus();
                }
            }
        }

        private void btmentes_Click(object sender, EventArgs e)
        {
            if (txnev.TextLength == 0)
            {
                MessageBox.Show("Kérem adja meg a tanuló nevét!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txnev.Focus();
            }
            else if (txosztaly.TextLength == 0)
            {
                MessageBox.Show("Kérem adja meg a tanuló osztályát!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txosztaly.Focus();
            }
            else if (cbhanyadika.SelectedItem == null)
            {
                MessageBox.Show("Kérem adja meg, hogy hányadikán volt!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbhanyadika.Focus();
            }
            else if (txigazolt.TextLength == 0)
            {
                MessageBox.Show("Kérem adja meg a tanuló igazolt hiányzását!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txigazolt.Focus();
            }
            else if (txnemigazolt.TextLength == 0)
            {
                MessageBox.Show("Kérem adja meg a tanuló nem igazolt hiányzását!", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
