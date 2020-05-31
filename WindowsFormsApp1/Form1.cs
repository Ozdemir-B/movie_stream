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
using System.Data.SqlClient;
using System.Windows.Documents;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        Form2 form2 = new Form2();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
          
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //hesaptan çık butonu
            
            form2.Show();
            this.Close();
        }
        public static string neworot;//yeni kullanıcı olup olmadığını belirtir //1->yeni 0->yeni değil

        List<string> turNamesList = new List<string>();
        List<string> programIDList = new List<string>();
        List<string> programNameList2 = new List<string>();

        public static string btn1;
        public static string btn2;
        public static string btn3;
        public static string btn4;
        public static string btn5;
        public static string btn6;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM userTablo where Id ='"+Form2.userID+"'" ;
            dr = cmd.ExecuteReader();
            if (dr.Read()) {
                label1.Text = dr["name"].ToString() + " " + dr["surname"].ToString();
            }
            //MessageBox.Show(Form2.userID + "-----");
            dr.Close();

            cmd.CommandText = "SELECT DISTINCT turName FROM userHistoryTablo where userID='" + Form2.userID.ToString() + "'";
            using (dr = cmd.ExecuteReader())
            {
                int f = 0;
                while (f < 3 && dr.Read())
                {
                    turNamesList.Add(dr["turName"].ToString());
                    f++;
                }
            }

            using (SqlCommand cmdnew = new SqlCommand("SELECT * FROM userTablo where Id='" + Form2.userID + "'", con))
            {
                using(SqlDataReader rdnew = cmdnew.ExecuteReader())
                {
                    if (rdnew.Read())
                    {
                        neworot = rdnew["new"].ToString();
                        
                    }
                }
            }

            if(neworot == "1")
            {
                for (int h = 0; h < 3; h++)
                {
                    cmd.CommandText = "SELECT DISTINCT programID FROM userHistoryTablo where turName='" + turNamesList[h].ToString() + "'";
                    using (SqlDataReader dr4 = cmd.ExecuteReader())
                    {
                        int o = 0;
                        while (o < 2 && dr4.Read())
                        {
                            programIDList.Add(dr4["programID"].ToString());
                            o++;
                        }
                    }

                }
                

                for (int y = 0; y < 6; y++)
                {
                    cmd.CommandText = "SELECT program from programTablo where Id='" + programIDList[y] + "'"; 

                    using (SqlDataReader dr5 = cmd.ExecuteReader())
                    {
                        int k = 0;
                        while (k < 1 && dr5.Read())
                        {
                            programNameList2.Add(dr5["program"].ToString());
                            k++;
                        }

                    }
                }

                using (SqlCommand cmd = new SqlCommand("UPDATE userTablo set new='0' where Id='" + Form2.userID + "'", con))
                {
                    cmd.ExecuteNonQuery();
                }
                neworot = "0";

                //groupBox texts
                groupBox1.Text = turNamesList[0];
                groupBox2.Text = turNamesList[1];
                groupBox4.Text = turNamesList[2];

                //button texts
                button1.Text = programNameList2[0];
                button2.Text = programNameList2[1];
                button3.Text = programNameList2[2];
                button4.Text = programNameList2[3];
                button5.Text = programNameList2[4];
                button6.Text = programNameList2[5];

            }

            else //not new
            {
                
                label3.Text = "İzlemeye Devam Et";
                using(SqlCommand cmdnot = new SqlCommand("SELECT * FROM userHistoryTablo where userID=@userid",con))
                {
                    cmdnot.Parameters.AddWithValue("@userid",Form2.userID);
                    using(SqlDataReader rdnot = cmdnot.ExecuteReader())
                    {
                        for(int f = 0; f < 6; f++)
                        {
                            rdnot.Read();
                            programIDList.Add(rdnot["programID"].ToString());
                            turNamesList.Add(rdnot["turName"].ToString());
                        }
                    }
                }
                for (int j = 0; j < 6; j++)
                {
                    using (SqlCommand cmdnot2 = new SqlCommand("SELECT * FROM programTablo where Id=@programid", con))
                    {
                        cmdnot2.Parameters.AddWithValue("@programid",programIDList[j]);
                        using (SqlDataReader rdnot2 = cmdnot2.ExecuteReader())
                        {
                            rdnot2.Read();
                            programNameList2.Add(rdnot2["program"].ToString());
                        }
                    }
                }
                
                groupBox1.Text = turNamesList[0] + "/" + turNamesList[1];
                groupBox2.Text = turNamesList[2] + "/" + turNamesList[3];
                groupBox4.Text = turNamesList[4] + "/" + turNamesList[5];

                //button texts
                button1.Text = programNameList2[0];
                button2.Text = programNameList2[1];
                button3.Text = programNameList2[2];
                button4.Text = programNameList2[3];
                button5.Text = programNameList2[4];
                button6.Text = programNameList2[5];
            }


            
            

            
           

            //button values kullanılmıyor.
            btn1 = programIDList[0];
            btn2 = programIDList[1];
            btn3 = programIDList[2];
            btn4 = programIDList[3];
            btn5 = programIDList[4];
            btn6 = programIDList[5];


            


            con.Close();
            

        }

        //open program in player
        public static string comboSelect;
        public static  int buttonOrNot = 0;
        public static string programButton= "";

        private void button1_Click(object sender, EventArgs e)
        {
            buttonOrNot = 1;
            programButton = button1.Text;
            player playerForm = new player();
            playerForm.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonOrNot = 1;
            programButton = button2.Text;
            player playerForm = new player();
            playerForm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            programButton = button3.Text;
            buttonOrNot = 1;
            player playerForm = new player();
            playerForm.Show();
            this.Hide();

        }

        //program adı araması -------------------------------------

        
        public static List<string> programNamesList = new List<string>();
        string comboText="";
        
        //string cbtext = "";
        private void button7_Click(object sender, EventArgs e)
        {
            

            using (SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True"))
            {
                con2.Open(); 
                using(SqlCommand cmd2 = new SqlCommand ("Select * from programTablo where program LIKE '"+comboBox1.Text+"%'",con2)) //tek eleman yerine bir kolonu seçtim.
                {
                    using (SqlDataReader rd2 = cmd2.ExecuteReader())
                    {
                        while (rd2.Read())
                        {
                            
                            programNamesList.Add(rd2["program"].ToString());
                            
                            
                        }

                        string[] programArray = programNamesList.ToArray();
                        for (int x = 0; x < programArray.Length; x++)
                        {
                            comboBox1.Items.Add(programArray[x]);
                        }
                        
                    }

                }
            }
        }
        // program adı araması ---------------------------



        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox1.Text);
            comboSelect = comboBox1.Text;
            buttonOrNot = 0;
            player PlayerForm = new player();
            PlayerForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonOrNot = 1;
            programButton = button4.Text;
            player PlayerForm = new player();
            PlayerForm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonOrNot = 1;
            programButton = button5.Text;
            player PlayerForm = new player();
            PlayerForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonOrNot = 1;
            programButton=button6.Text;
            player PlayerForm = new player();
            PlayerForm.Show();
            this.Hide();
        }

        //tür adı araması ----------------------------------
        

        List<string> turAdiList = new List<string>();

        private void button8_Click(object sender, EventArgs e)
        {
            using (SqlConnection con2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\VisualStudioProjects\WindowsFormsApp1\WindowsFormsApp1\Database.mdf;Integrated Security=True"))
            {
                con2.Open();
                using (SqlCommand cmd2 = new SqlCommand("Select * from programTablo where tur LIKE '%" + comboBox1.Text + "%'", con2)) 
                {
                    using (SqlDataReader rd2 = cmd2.ExecuteReader())
                    {
                        while (rd2.Read())
                        {

                            turAdiList.Add(rd2["program"].ToString());
                            

                        }

                        string[] turAdiArray = turAdiList.ToArray();
                        for (int x = 0; x < turAdiArray.Length; x++)
                        {
                            comboBox1.Items.Add(turAdiArray[x]);
                        }
                       
                    }

                }
            }
        }
        // tür adi araması -------------------------------------

        
    }
}
