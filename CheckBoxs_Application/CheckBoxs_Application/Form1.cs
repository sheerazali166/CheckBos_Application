using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxs_Application
{
    public partial class Form1 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["csdb"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("Sp_For_Inserting_Data", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", textBoxName.Text);
            cmd.Parameters.AddWithValue("@cricket", checkBoxCricket.Checked);
            cmd.Parameters.AddWithValue("@hockey", checkBoxHockey.Checked);
            cmd.Parameters.AddWithValue("@football", checkBoxFootball.Checked);

            conn.Open();


            int n = cmd.ExecuteNonQuery();

            if (n > 0)
            {

                MessageBox.Show("Insertion Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {

                MessageBox.Show("Insertion Failed.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();


        }
    }
}
