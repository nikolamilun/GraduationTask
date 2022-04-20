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
    }
}
