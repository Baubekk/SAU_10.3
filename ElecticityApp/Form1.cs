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
        private void btnElcetro_MouseEnter(object sender, EventArgs e)
        {
            btnElectro.ForeColor = Color.Black;
            btnElectro.BackColor = SystemColors.Control;
        }

        private void btnElectro_MouseLeave(object sender, EventArgs e)
        {
            btnElectro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnElectro.ForeColor = Color.White;
        }

        private void btnZadachi_MouseEnter(object sender, EventArgs e)
        {
            btnZadachi.ForeColor = Color.Black;
            btnZadachi.BackColor = SystemColors.Control;
        }

        private void btnZadachi_MouseLeave(object sender, EventArgs e)
        {
            btnZadachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnZadachi.ForeColor = Color.White;
        }

        private void btnCalc_MouseEnter(object sender, EventArgs e)
        {
            btnCalc.ForeColor = Color.Black;
            btnCalc.BackColor = SystemColors.Control;
        }

        private void btnCalc_MouseLeave(object sender, EventArgs e)
        {
            btnCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            btnCalc.ForeColor = Color.White;
        }

        private void btnElectro_Click(object sender, EventArgs e)
        {
            panel_Electrostatika.Visible = true;
            panel_Zadachi.Visible = false;
        }

        private void btnZadachi_Click(object sender, EventArgs e)
        {
            panel_Electrostatika.Visible = false;
            panel_Zadachi.Visible = true;
            panel_Calc.Visible = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            panel_Calc.Visible = true;
            panel_Zadachi.Visible = false;
            panel_Electrostatika.Visible = false;
        }


    }
}
