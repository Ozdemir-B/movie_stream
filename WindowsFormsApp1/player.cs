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
    public partial class player : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True");


        public player()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)//çıkış(geri butonu)-----------------------
        {
            //veritabanına kaydetme işi burada yapılacak.
            timer1.Enabled = false;
            if(izlenecekProgramId=="122" && puan == 7 && kalinanSure == 7)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=MiKuhfDjims");
            }
            using (SqlCommand kaydet = new SqlCommand("UPDATE userHistoryTablo set turName=@turnm, izlemeSuresi=@izlemesuresi, bolum=@blm, puan=@score where programID=@progID AND userID=@usrID",con))
            {
                kaydet.Parameters.AddWithValue("@score",puan);
                kaydet.Parameters.AddWithValue("@blm",kalinanBolum);
                kaydet.Parameters.AddWithValue("@izlemesuresi",kalinanSure);
                kaydet.Parameters.AddWithValue("@usrID", Form2.userID);
                kaydet.Parameters.AddWithValue("@progID",izlenecekProgramId);
                kaydet.Parameters.AddWithValue("@turnm",izlenecekProgramTurName);
                kaydet.ExecuteNonQuery();
            }
                
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            con.Close();
        }
        int izlenmisMi;

        string izlenecekProgram = "";
        string izlenecekProgramId = "";
        string izlenecekProgramUzunluk = "";
        string izlenecekProgramBolum = "";
        string izlenecekProgramTurName = "";

        string historyUzunluk="";
        string historyBolum = "";
        string historyTurName = "";

        int kalinanSure;
        int saatTipindeUzunluk;
        int kalinanBolum;

        int puan;

        private void player_Load(object sender, EventArgs e)
        {
            if (Form1.buttonOrNot == 0)
            {
                izlenecekProgram = Form1.comboSelect;
            }
            else
            {
                izlenecekProgram = Form1.programButton;
            }
            con.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM programTablo where program='"+izlenecekProgram+"'",con))
            {
                using(SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        izlenecekProgramId = rd["Id"].ToString();
                        izlenecekProgramUzunluk = rd["uzunluk"].ToString();
                        izlenecekProgramBolum = rd["bolum"].ToString();
                        izlenecekProgramTurName = rd["tur"].ToString();
                        //MessageBox.Show(rd["turName"].ToString());
                    }
                    
                }
            }
            //MessageBox.Show(izlenecekProgramTurName);
            
            
            
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM userHistoryTablo where programID ='"+izlenecekProgramId+"'",con))
            {
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    if (rd.Read())
                    {
                        if (rd["bolum"].ToString() == "")
                        {
                            izlenmisMi = 0; 
                        }
                        else
                        {
                            
                            izlenmisMi = 1; 
                            historyBolum = rd["bolum"].ToString();
                            historyUzunluk = rd["izlemeSuresi"].ToString();
                            historyTurName = rd["turName"].ToString();
                            kalinanBolum = Convert.ToInt32(historyBolum);
                            puan = Convert.ToInt32(rd["puan"].ToString());
                            
                            
                        }
                        
                    }
                    else
                    {
                        izlenmisMi = 0; 
                        
                    }
                }
            }
            label1.Text = historyUzunluk+" sn/" + izlenecekProgramUzunluk+" dk";
            label2.Text = "BÖLÜM:1/" + izlenecekProgramBolum;

            if (izlenmisMi == 0)
            {
                kalinanSure = 0;
                using(SqlCommand cmd = new SqlCommand("INSERT INTO userHistoryTablo(programID,turName,userID) values('"+izlenecekProgramId+"',@tur,'"+Form2.userID+"')",con))
                {
                    cmd.Parameters.AddWithValue("@tur",izlenecekProgramTurName);
                    cmd.ExecuteNonQuery();
                }
            }
            
            else
            {
                
                kalinanSure = Convert.ToInt32(historyUzunluk);
            }
            if (izlenecekProgramBolum == "1")
            {
                label2.Text = "BÖLÜM:1";
            }

            else
            {
                label2.Text = "BÖLÜM:" + kalinanBolum.ToString();
            }
            
            

        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            saatTipindeUzunluk = Convert.ToInt32(izlenecekProgramUzunluk);
            if (kalinanSure == saatTipindeUzunluk*60)
            {
                timer1.Enabled = false;
            }
            kalinanSure++;
            label1.Text = kalinanSure.ToString() + " sn/" + izlenecekProgramUzunluk+" dk";

            

        }

        private void button12_Click(object sender, EventArgs e) //BAŞLA BUTONU ----------------------
        {
            timer1.Enabled = true;

        }

        private void button13_Click(object sender, EventArgs e) //durdur butonu ---------------------------
        {
            timer1.Enabled = false;
        }

        //puanlama ------------------------------------------------------------------
        
        private void button1_Click(object sender, EventArgs e)
        {
            puan = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            puan = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            puan = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            puan = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            puan = 5;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            puan = 6;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            puan = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            puan = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            puan = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            puan = 10;
        }
        //puanlama---------------------------------------------------------------------------------

        private void button16_Click(object sender, EventArgs e)//başa sar butonu ------------------
        {
            kalinanSure = 0;
            timer1.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (izlenecekProgramBolum == "1")
            {
                kalinanBolum = 1;
            }
            else
            {
                if (kalinanBolum <= Convert.ToInt32(izlenecekProgramBolum))
                {
                    kalinanBolum++;
                    timer1.Enabled = false;
                    kalinanSure = 0;
                    label2.Text = "BÖLÜM:" + kalinanBolum.ToString();
                    label1.Text = kalinanSure.ToString() + " sn/" + izlenecekProgramUzunluk + " dk";
                }
            }
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(izlenecekProgramBolum == "1")
            {
                kalinanBolum = 1;
            }
            else
            {
                if (kalinanBolum >= 1)
                {
                    kalinanBolum--;
                    timer1.Enabled = false;
                    kalinanSure = 0;
                    label2.Text = "BÖLÜM:" + kalinanBolum.ToString();
                    label1.Text = kalinanSure.ToString() + " sn/" + izlenecekProgramUzunluk + " dk";
                }
            }
            
        }
    }
}
