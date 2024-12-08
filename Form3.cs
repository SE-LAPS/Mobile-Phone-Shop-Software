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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DisplayTable();
        }


        SqlConnection sc = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Pc\Documents\mobiledb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        public void DisplayTable()
        {
            {
                sc.Open();
                string qu = "SELECT  * FROM phone ";
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
            int id = int.Parse(textBox1.Text);
            string brand = comboBox1.Text;
            string model_name = comboBox2.Text;
            string android_version = comboBox3.Text;
            string network_type = comboBox8.Text;
            string weight = comboBox7.Text;
            string sim_type = comboBox6.Text;
            string phone_processors = comboBox5.Text;
            string display = comboBox4.Text;
            string fp_sensor = comboBox13.Text ;
            string internal_storage = comboBox12.Text;
            string ram = comboBox11.Text;
            string expandable_memory = comboBox10.Text;
            string real_camera = comboBox9.Text;
            string font_camera = comboBox14.Text;
 
            try
          {
                sc.Open();
                SqlCommand com = new SqlCommand ("INSERT INTO phone (id , Brand, Model Name, Android Version,Network type , weight,Sim Type, Phone processors,Display,FP Sensor,Internal Storage,RAM,Expandable Memory,Real Camera,Main Camera)"+" VALUES (@id,@Brand,@Model Name,@Android Version,@Network Type ,@Weight,@sim type,@Phone_ Processors , @Display,@FP Sensor,@Internal storage,@RAM,@Expandable Memory,@Real Camer ,@Main Camera )",sc);
   
                com.Parameters.AddWithValue("@id ",id);
                com.Parameters.AddWithValue("@model name ",model_name);
                com.Parameters.AddWithValue("@android version ",android_version);
                com.Parameters.AddWithValue("@network type ",network_type);
                com.Parameters.AddWithValue("@weight ",weight);
                com.Parameters.AddWithValue("sim type ",sim_type);
                com.Parameters.AddWithValue("phone processors ",phone_processors);
                com.Parameters.AddWithValue("display ",display);
                com.Parameters.AddWithValue("fp sensor ",fp_sensor);
                com.Parameters.AddWithValue("internal storage ",internal_storage);
                com.Parameters.AddWithValue("ram ",ram);
                com.Parameters.AddWithValue("expandable memory ",expandable_memory);
                com.Parameters.AddWithValue("real camera ",real_camera);
                com.Parameters.AddWithValue("font camera ",font_camera);

                com.ExecuteNonQuery();
                sc.Close();
                DisplayTable();
          }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            string brand = comboBox1.Text;
            string model_name = comboBox2.Text;
            string android_version = comboBox3.Text;
            string network_type = comboBox8.Text;
            string weight = comboBox7.Text;
            string sim_type = comboBox6.Text;
            string phone_processors = comboBox5.Text;
            string display = comboBox4.Text;
            string fp_sensor = comboBox13.Text ;
            string internal_storage = comboBox12.Text;
            string ram = comboBox11.Text;
            string expandable_memory = comboBox10.Text;
            string real_camera = comboBox9.Text;
            string font_camera = comboBox14.Text;
 
            try
          {
                sc.Open();
                SqlCommand UP = new SqlCommand ("UPDATE phone SET brand=@brand , model name=@model name,android version=@android version,network type =@Network Type ,weight =@weight , sim type =@sim type, phone processors=@phone processors ,display = @display,fp sensor=@fp sensor ,internal storage=@internal storage,ram= @ram,expandable meomry=@expandable memory,real camera=@real camera ,font camera=@font camera ",sc );
 

                UP.Parameters.AddWithValue("@id ",id);
                UP.Parameters.AddWithValue("@Model Name ",model_name); 
                UP.Parameters.AddWithValue("@Android Version ",android_version);
                UP.Parameters.AddWithValue("@Network Type ",network_type);
                UP.Parameters.AddWithValue("@Weight ",weight);
                UP.Parameters.AddWithValue("Sim Type ",sim_type);
                UP.Parameters.AddWithValue("Phone Processors ",phone_processors);
                UP.Parameters.AddWithValue("Display ",display);
                UP.Parameters.AddWithValue("Fp Sensor ",fp_sensor);
                UP.Parameters.AddWithValue("Internal Storage ",internal_storage);
                UP.Parameters.AddWithValue("RAM ",ram);
                UP.Parameters.AddWithValue("Expandable Memory ",expandable_memory);
                UP.Parameters.AddWithValue("Real camera ",real_camera);
                UP.Parameters.AddWithValue("Main camera ",font_camera);

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
            dataGridView1.CurrentRow.Selected= true;
            textBox1.Text=dataGridView1.Rows [ e.RowIndex].Cells["id"].Value.ToString();
            comboBox1.Text=dataGridView1.Rows[e.RowIndex].Cells["brand "].Value.ToString();
            comboBox2.Text=dataGridView1.Rows[e.RowIndex].Cells["model name"].Value.ToString();
            comboBox3.Text=dataGridView1.Rows[e.RowIndex].Cells["android version"].Value.ToString();
            comboBox8.Text=dataGridView1.Rows[e.RowIndex].Cells["network type "].Value.ToString();
            comboBox7.Text=dataGridView1.Rows[e.RowIndex].Cells["weight "].Value.ToString();
            comboBox6.Text=dataGridView1.Rows[e.RowIndex].Cells["sim type"].Value.ToString();
            comboBox5.Text=dataGridView1.Rows[e.RowIndex].Cells["phone processors "].Value.ToString();
            comboBox4.Text=dataGridView1.Rows[e.RowIndex].Cells["display"].Value.ToString();
            comboBox13.Text=dataGridView1.Rows[e.RowIndex].Cells["fp sensor"].Value.ToString();
            comboBox12.Text=dataGridView1.Rows[e.RowIndex].Cells["internal storage "].Value.ToString();
            comboBox11.Text=dataGridView1.Rows[e.RowIndex].Cells["ram"].Value.ToString();
            comboBox10.Text=dataGridView1.Rows[e.RowIndex].Cells["expandable memory" ].Value.ToString();
            comboBox9.Text=dataGridView1.Rows[e.RowIndex].Cells["real camera "].Value.ToString();
            comboBox14.Text=dataGridView1.Rows[e.RowIndex].Cells["font camera "].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBox1.Text);
            try
            {
                sc.Open();
                SqlCommand co = new SqlCommand("DELETE FROM phone  WHERE id = @id ", sc);

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

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        }
        }
        
        
    

