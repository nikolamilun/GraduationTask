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
        // Here you type the name of your SQL server instance
        public static string serverName = "LIMUNPC\\NIKOLASRVSQL";
        public Form1()
        {
            InitializeComponent();
        }
        // Start of the application
        private void Form1_Load(object sender, EventArgs e)
        {
            // Opening the SQL connection
            using (SqlConnection cnn = new SqlConnection(@"Data Source= " + serverName + "; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                cnn.Open();
                // Use the procedure from the database
                SqlCommand sela = new SqlCommand("seloPodaci", cnn);
                sela.CommandType = CommandType.StoredProcedure;
                // Reading data and putting it into the listView
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
                // Filling the comboBox
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
            // Changing form data when the content of the ID textbox is changed
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
        // Save the changes in the database
        private void btnUnesiIzmene_Click(object sender, EventArgs e)
        {
            // Opening the SQL connection
            using (SqlConnection cnn = new SqlConnection(@"Data Source= " + serverName + "; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                cnn.Open();
                int sifra;
                // Checking if the entered values are correct
                bool moze = int.TryParse(tbSifra.Text, out sifra);
                if (moze && tbNaziv.Text.Length < 16 && tbSifra.Text != "")
                {
                    // Using the stored procedure to update the database
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
                            // Checking if the update suceeded
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
                            // Error message
                            MessageBox.Show("Neuspesno!, razlog u datoteci error.txt", "Neuspeh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            StreamWriter sr = new StreamWriter("error.txt", true);
                            DateTime dt = DateTime.Now;
                            // Error log
                            sr.WriteLine(dt.ToString() + " - error message: " + exc.Message);
                            sr.Close();
                        }
                    }
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            // Closing the application
            Close();
        }

        private void btnOAplikaciji_Click(object sender, EventArgs e)
        {
            // Opening another form
            Form3 popup = new Form3();
            popup.Show();
        }

        private void btnDodeliVaucere_Click(object sender, EventArgs e)
        {
            // Yet another form
            Form2 popup = new Form2();
            popup.Show();
        }
    }
}
