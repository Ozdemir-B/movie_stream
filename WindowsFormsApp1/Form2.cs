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
using System.Security.Cryptography.X509Certificates;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {


        SqlConnection con;
       
        
        public static string idd = "";
        public static string pass = "";
        public static string userID = "";
        


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True");
            con.Open();
           
            SqlCommand cmd = new SqlCommand("SELECT * FROM userTablo where email='" + textBox1.Text.ToString() + "' AND password='" + textBox2.Text.ToString() + "'",con);
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                idd = textBox1.Text;
                pass = textBox2.Text;
                userID = dr["Id"].ToString();
                dr.Close();
                
                using(SqlCommand cmd2 = new SqlCommand("SELECT * FROM userTablo where Id =" + userID + "", con))
                {
                    using (SqlDataReader dr2 = cmd2.ExecuteReader()) 
                    {
                        
                        dr2.Read();
                        if (dr2["new"].ToString() == "1")
                        {
                            con.Close();
                            newUser newusr = new newUser();
                            newusr.Show();
                            this.Hide();
                        }
                        else
                        {
                            con.Close();
                            form1.Show();
                            this.Hide();
                        }
                   
                    }
                }
                
                
                
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            //con.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
