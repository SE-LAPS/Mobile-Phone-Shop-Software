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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }


        SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pc\Documents\mobiledb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public void DisplayTable()
        {
            
            {
                sc.Open();
                string qu = "SELECT * FROM Customer ";
                SqlDataAdapter ad = new SqlDataAdapter(qu, sc);
                SqlCommandBuilder cb = new SqlCommandBuilder(ad);
                DataSet ds = new DataSet();
                ad.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                sc.Close();
            }


        }
    
      

        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);
            string name = textBox1.Text;
            string gender = comboBox1.Text;
            int contact_no =int.Parse( textBox2.Text);
            string nic = textBox8.Text;
            string address = textBox3.Text;
            string brand = comboBox2.Text;
            string price = textBox4.Text;
            DateTime date = dateTimePicker1.Value;

            try
          { 
               sc.Open ();
              SqlCommand com= new SqlCommand("INSERT INTO Customer (id , Name ,Gender , contact _ No , NIC , Address , Brand , price , date )"+" VALUES (@id , @Name , @Gender , @Contact No ,@NIC ,@Address , @Brand , @Price ,@date )",sc);

              com.Parameters.AddWithValue("@ID", id);
              com.Parameters.AddWithValue("@name" , name);
              com.Parameters.AddWithValue("@Gender" , gender );
              com.Parameters.AddWithValue("@contact no ",contact_no );
              com.Parameters.AddWithValue("@NIC " , nic );
              com.Parameters.AddWithValue("@Address " , address );
              com.Parameters.AddWithValue("@Brand " , brand );
              com.Parameters.AddWithValue("@Gender " , gender ) ;
              com.Parameters.AddWithValue("@price " , price ) ;
              com.Parameters.AddWithValue("@date " , date ) ;

              
              com.ExecuteNonQuery();
              sc.Close ();
              DisplayTable( );
            }
            catch(Exception ex )
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox5.Text);
            string name = textBox1.Text;
            string gender = comboBox1.Text;
            int contact_no =int.Parse( textBox2.Text);
            int nic = int.Parse(textBox8.Text);
            string address = textBox3.Text;
            string brand = comboBox2.Text;
            string price = textBox4.Text;
            DateTime date = dateTimePicker1.Value;
            try
        { 
            sc.Open ();
              SqlCommand UP= new SqlCommand("UPDATE customer SET  name =@name ,gender = @gender , contact _ no = @contact no , nic = @nic , address  = @address, brand =@brand , price = @price , date = @date  WHERE ID = @id ",sc );

              UP.Parameters.AddWithValue("@ID", id);
              UP.Parameters.AddWithValue("@name" , name);
              UP.Parameters.AddWithValue("@Gender" , gender );
              UP.Parameters.AddWithValue("@contact no ",contact_no );
              UP.Parameters.AddWithValue("@NIC " , nic );
              UP.Parameters.AddWithValue("@Address " , address );
              UP.Parameters.AddWithValue("@Brand " , brand );
              UP.Parameters.AddWithValue("@Gender " , gender ) ;
              UP.Parameters.AddWithValue("@price " , price ) ;
              UP.Parameters.AddWithValue("@date " , date ) ;

              UP.ExecuteNonQuery();
              sc.Close ();
              DisplayTable( );
            }
            
        
            catch(Exception ex )
           {
                MessageBox.Show (ex.Message);
            } 
        }
        
        


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true ;
            textBox5.Text = dataGridView1.Rows [ e .RowIndex ] .Cells [ "ID " ] .Value.ToString ();
            textBox1.Text = dataGridView1.Rows [ e.RowIndex].Cells  ["Name " ] .Value.ToString();
            comboBox1.Text = dataGridView1.Rows [ e.RowIndex] .Cells ["Gender "].Value.ToString();
            textBox2.Text = dataGridView1.Rows [ e .RowIndex ] .Cells ["Contact No " ] .Value.ToString();
            textBox8.Text = dataGridView1 .Rows [e.RowIndex ] .Cells ["NIC " ] .Value.ToString();
            textBox3.Text = dataGridView1.Rows [ e.RowIndex ] .Cells ["Adress " ] .Value.ToString();
            comboBox2.Text = dataGridView1.Rows [ e.RowIndex ] .Cells ["Brand " ] .Value.ToString();
            textBox4.Text = dataGridView1.Rows [ e.RowIndex ] .Cells ["Price " ] .Value.ToString ();
            dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["Date "].Value.ToString()); 

                           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(textBox5.Text);
            try
            {
                sc.Open();
                SqlCommand co = new SqlCommand("DELETE FROM Dinstructor WHERE id = @id ", sc);

                co.Parameters.AddWithValue("@id", id);

                co.ExecuteNonQuery();
                sc.Close();
                DisplayTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        }
    }




