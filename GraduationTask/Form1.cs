using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;

namespace GraduationTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source= LIMUNPC\NIKOLASRVSQL; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                cnn.Open();
                SqlCommand sela = new SqlCommand("seloPodaci", cnn);
                sela.CommandType = CommandType.StoredProcedure;
                using (SqlDataReader sdr = sela.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        ListViewItem lwi = new ListViewItem(sdr.GetValue(0).ToString());
                        lwi.SubItems.Add(sdr.GetValue(1).ToString().Trim(' '));
                        lwi.SubItems.Add(sdr.GetValue(2).ToString().Trim(' '));
                        listView1.Items.Add(lwi);
                    }
                }
                SqlCommand gradovi = new SqlCommand("SELECT Grad FROM grad ORDER BY Grad ASC", cnn);
                using (SqlDataReader sdr = gradovi.ExecuteReader())
                {
                    while (sdr.Read())
                    {
                        cbGrad.Items.Add(sdr.GetValue(0).ToString().Trim(' '));
                    }
                }
            }
        }

        private void tbSifra_TextChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == tbSifra.Text)
                {
                    item.Selected = true;
                    tbNaziv.Text = item.SubItems[1].Text.ToString();
                    cbGrad.SelectedItem = item.SubItems[2].Text.ToString();
                }
            }
        }

        private void btnUnesiIzmene_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(@"Data Source= LIMUNPC\NIKOLASRVSQL; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                cnn.Open();
                int sifra;
                bool moze = int.TryParse(tbSifra.Text, out sifra);
                if (moze && tbNaziv.Text.Length < 16 && tbSifra.Text != "")
                {
                    using (SqlCommand cmd = new SqlCommand("updateSelo", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add("@id", SqlDbType.Int);
                        cmd.Parameters["@id"].Value = sifra;
                        cmd.Parameters.Add("@nazivSelo", SqlDbType.NChar, 15);
                        cmd.Parameters["@nazivSelo"].Value = tbNaziv.Text;
                        cmd.Parameters.Add("@nazivGrad", SqlDbType.NChar, 15);
                        cmd.Parameters["@nazivGrad"].Value = cbGrad.GetItemText(cbGrad.SelectedItem);
                        try
                        {
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                MessageBox.Show("Uspesan upis!", "Uspeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                foreach (ListViewItem lwi in listView1.Items)
                                {
                                    if (lwi.SubItems[0].Text == tbSifra.Text)
                                    {
                                        lwi.SubItems[1].Text = tbNaziv.Text;
                                        lwi.SubItems[2].Text = cbGrad.GetItemText(cbGrad.SelectedItem);
                                    }
                                }
                            }
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show("Neuspesno!, razlog u datoteci error.txt", "Neuspeh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            StreamWriter sr = new StreamWriter("error.txt", true);
                            DateTime dt = DateTime.Now;
                            sr.WriteLine(dt.ToString() + " - error message: " + exc.Message);
                            sr.Close();
                        }
                    }
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOAplikaciji_Click(object sender, EventArgs e)
        {
            Form3 popup = new Form3();
            popup.Show();
        }

        private void btnDodeliVaucere_Click(object sender, EventArgs e)
        {
            Form2 popup = new Form2();
            popup.Show();
        }
    }
}
