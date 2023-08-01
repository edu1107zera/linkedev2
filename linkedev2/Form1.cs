using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linkedev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }



        private void btnDE_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.DarkRed;
            panelTop.BackColor = Color.Red;

            btnDE.BackColor = Color.Red;
            btnPRO.BackColor = Color.OrangeRed;
            btnMO.BackColor = Color.OrangeRed;
            btnFRO.BackColor = Color.OrangeRed;
        }


       

        private void btnPRO_Click(object sender, EventArgs e)
        {
            panelTop.BackColor = Color.SkyBlue;
            panelLogo.BackColor = Color.Blue;
           
            btnPRO.BackColor = Color.SkyBlue;
           
            btnDE.BackColor = Color.OrangeRed;
            btnMO.BackColor = Color.OrangeRed;
            btnFRO.BackColor = Color.OrangeRed;
        }
        private void btnMO_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.DarkGreen;
            panelTop.BackColor = Color.Green;

            btnMO.BackColor = Color.Green;

            btnDE.BackColor = Color.OrangeRed;
            btnPRO.BackColor= Color.OrangeRed;
            btnFRO.BackColor = Color.OrangeRed;
        }

        private void btnFRO_Click(object sender, EventArgs e)
        {
            panelLogo.BackColor = Color.BlueViolet;
            panelTop.BackColor = Color.Violet;

            btnFRO.BackColor = Color.Violet;

            btnMO.BackColor = Color.OrangeRed;
            btnDE.BackColor = Color.OrangeRed;
            btnPRO.BackColor = Color.OrangeRed;
        }

    }
}

           

            

           


           



