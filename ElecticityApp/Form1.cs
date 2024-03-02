using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElecticityApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void btnElcetro_MouseHover(object sender, EventArgs e)
        {
            btnElectro.ForeColor = Color.Black;
            btnElectro.BackColor = SystemColors.Control;
        }

        private void btnElectro_MouseLeave(object sender, EventArgs e)
        {
            btnElectro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnElectro.ForeColor = Color.White;
        }

        private void btnZadachi_MouseHover(object sender, EventArgs e)
        {
            btnZadachi.ForeColor = Color.Black;
            btnZadachi.BackColor = SystemColors.Control;
        }

        private void btnZadachi_MouseLeave(object sender, EventArgs e)
        {
            btnZadachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnZadachi.ForeColor = Color.White;
        }

        private void btnCalc_MouseHover(object sender, EventArgs e)
        {
            btnCalc.ForeColor = Color.Black;
            btnCalc.BackColor = SystemColors.Control;
        }

        private void btnCalc_MouseLeave(object sender, EventArgs e)
        {
            btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnCalc.ForeColor = Color.White;
        }




    }
}
