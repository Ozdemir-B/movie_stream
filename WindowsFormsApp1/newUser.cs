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

namespace WindowsFormsApp1
{
    public partial class newUser : Form
    {

        
        List<int> idList = new List<int>();
        public static int[] turArray;  
        List<string> programIDList = new List<string>();
        List<string> turNameList = new List<string>();
   
        
        public newUser()
        {
            InitializeComponent();
        }

        int ch = 3;
        int devam = 0;

        private void newUser_Load(object sender, EventArgs e)
        {

            label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (ch != 0) 
            {
                MessageBox.Show("lütfen sadece" + " 3 tür seçiniz");
                
            }
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True"))
                {
                    con.Open();
                    
                    for (int b = 0; b < 3; b++)
                    {
                        using (SqlCommand cmd1 = new SqlCommand("SELECT * FROM turTablo where Id='" + idList[b] + "'", con))
                        {
                            using (SqlDataReader rd1 = cmd1.ExecuteReader())
                            {
                                int h = 0;
                                while(h<3 && rd1.Read())
                                {
                                    
                                    turNameList.Add(rd1["tur"].ToString());
                                    h++;
                                    
                                }
                            }
                        }
                        using(SqlCommand cmd2 = new SqlCommand("SELECT * FROM programTablo where tur LIKE '%" + turNameList[b] + "%'", con))
                        {
                            using (SqlDataReader rd2 = cmd2.ExecuteReader())
                            {
                                int s = 0;
                                while(s<2 && rd2.Read())
                                {
                                    programIDList.Add(rd2["Id"].ToString());
                                    s++;
                                }
                            }
                        }
                        for(int j = 0; j < 2; j++)
                        {
                            using (SqlCommand cmd3 = new SqlCommand("INSERT INTO userHistoryTablo(programID,userID,turName) values('"+programIDList[j]+"','"+Form2.userID+"','"+turNameList[b]+"')", con))
                            {
                                cmd3.ExecuteNonQuery();
                            }
                        }
                        programIDList.Clear();
                        
                    }
                    //insert program suggestions ------------------------------------------------
                }
                turArray = idList.ToArray();
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();

            }
        }

        private void aksiyonMaceraCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (aksiyonMaceraCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Add(1); }
                if (!aksiyonMaceraCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(1); }
            

        }

        private void bilimKurguCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (bilimKurguCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Add(2); }
                if (!bilimKurguCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Remove(2); }
            
        }

        private void romantikCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (romantikCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(3); }
                if (!romantikCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(3); }
            
        }

        private void dramaCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (dramaCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Add(4); }
                if (!dramaCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(4); }
            
        }

        private void cocukCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (cocukCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(5); }
                if (!cocukCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(5); }
            
        }

        private void belgeselCheck_CheckedChanged(object sender, EventArgs e)
        {
            
                if (belgeselCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Add(6); }
                if (!belgeselCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(6); }
            
        }

        private void komediCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (komediCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(7); }
                if (!komediCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(7); }
           
        }

        private void bilimDogaCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (bilimDogaCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(8); }
                if (!bilimDogaCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(8); }
            
        }

        private void korkuCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (korkuCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz.";idList.Add(9); }
                if (!korkuCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(9); }
           
        }

        private void gerilimCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (gerilimCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(10); }
                if (!gerilimCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(10); }
            
        }

        private void realityCheck_CheckedChanged(object sender, EventArgs e)
        {
           
                if (realityCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(11); }
                if (!realityCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(11); }
           
        }

        private void animeCheck_CheckedChanged(object sender, EventArgs e)
        {
            
            if (animeCheck.Checked) { ch--; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Add(12); }
            if (!animeCheck.Checked) { ch++; label1.Text = "HOŞGELDİNİZ. Lütfen en sevdiğiniz " + ch.ToString() + " türü seçiniz."; idList.Remove(12); }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }
    }
}
