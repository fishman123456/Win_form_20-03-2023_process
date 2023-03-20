using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Win_form_20_03_2023_process
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
                InitializeComponent();
                Process.StartInfo = new System.Diagnostics.
                ProcessStartInfo("calc.exe");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.CloseMainWindow();
            Process.Close();
        }

       
    }
}
