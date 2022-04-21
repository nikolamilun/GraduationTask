using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Collections;

namespace GraduationTask
{
    public partial class Form2 : Form
    {
        Dictionary<int, string> dict;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dict = new Dictionary<int, string>();
            using (SqlConnection cnn = new SqlConnection(@"Data Source= LIMUNPC\NIKOLASRVSQL; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                using (SqlCommand cmd = new SqlCommand("brRezPoKl", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dict.Add(sdr.GetInt32(0), sdr.GetString(1));
                    }
                }
            }
            btnPrikazi_Click(this, e);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            int granica = (int)numericUpDown1.Value;
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                if (kvp.Key > granica)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = kvp.Key;
                    row.Cells[1].Value = kvp.Value;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
