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
        // The dictionary to store table data into
        Dictionary<int, string> dict;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initalization of the dictionary
            dict = new Dictionary<int, string>();
            // Opening the SQL conncection
            using (SqlConnection cnn = new SqlConnection(@"Data Source= " + Form1.serverName +"; Initial Catalog= graduationTask; Integrated Security= true"))
            {
                // Aand another stored procedure
                using (SqlCommand cmd = new SqlCommand("brRezPoKl", cnn))
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Using the SDR to read data
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        // Writing data in the dictionary
                        dict.Add(sdr.GetInt32(0), sdr.GetString(1));
                    }
                }
            }
            // Using the function down below to fill the data table
            btnPrikazi_Click(this, e);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            // Setting the data source and clearing the table to null in order to refresh it
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            // Reading the border value
            int granica = (int)numericUpDown1.Value;
            // Looping through the dictionary
            foreach (KeyValuePair<int, string> kvp in dict)
            {
                // See if the key is meeting the requirements
                if (kvp.Key >= granica)
                {
                    // Adding the row if it meets the required value
                    DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = kvp.Key;
                    row.Cells[1].Value = kvp.Value;
                    dataGridView1.Rows.Add(row);
                }
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            // Exit
            Close();
        }
    }
}
