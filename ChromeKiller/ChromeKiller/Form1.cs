using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChromeKiller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

        }//end Form1()

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (System.Diagnostics.Process proc in System.Diagnostics.Process.GetProcessesByName("chrome"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            Application.Exit();

        }//end Click()

        
    }//end class
}// end namespace
