using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pc\Documents\mobiledb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True"); 
        private void DisplayTable()
        {
            conn.Open();
            string query = "SELECT * FROM  Cusomer ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CUSTOMER DETAILS WHERE ID = @ID ", conn);
                {
                    cmd.Parameters.AddWithValue("@ID ", textBox5.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    MessageBox.Show("ok");
                }
                cmd.ExecuteNonQuery();
                conn.Close();
                DisplayTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

    }

}
