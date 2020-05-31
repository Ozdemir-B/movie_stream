using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class aramaForm : Form
    {
        public aramaForm()
        {
            InitializeComponent();
        }

        string[] programArray = Form1.programNamesList.ToArray();

        private void aramaForm_Load(object sender, EventArgs e)
        {
            //listBox1.Items.Add(Form1.programNamesList);
            MessageBox.Show(Form1.programNamesList[0]);

            /*ListBox lb = new ListBox();

            
            for(int i = 0; i < programArray.Length; i++)
            {
                lb.Items.Add(programArray[i]);
            }
            this.listBox1.Items.Add(lb);*/
        }
    }
}
