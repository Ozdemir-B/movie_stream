using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True");
        


        private void button1_Click(object sender, EventArgs e)
        {
            string date = textBox5.Text + "/" + textBox6.Text + "/" + textBox7.Text;
            con.Open();
            SqlCommand chek = new SqlCommand("SELECT * FROM userTablo where email='"+textBox3.Text+"'", con);
            SqlDataReader chekRd = chek.ExecuteReader();
            if (chekRd.Read()) { MessageBox.Show("bu e-mail kullanılıyor."); }
            else 
            {
                chekRd.Close();
                SqlCommand cmd = new SqlCommand("INSERT INTO userTablo(name,surname,email,password,date,new) VALUES('" + textBox1.Text + "','" + textBox2.Text + " ','" + textBox3.Text + "',' " + textBox4.Text + "',@date,'1')", con);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("UPDATE userTablo set name='" + textBox1.Text + "',surname='" + textBox2.Text + "',email='" + textBox3.Text + "',password='" + textBox4.Text + "',new = '1' where email='" + textBox3.Text + "'", con);
                cmd2.ExecuteNonQuery();
                con.Close();
                Form2 form2 = new Form2();
                form2.Show();
                this.Close();
            }
                      
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
