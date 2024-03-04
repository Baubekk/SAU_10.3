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
        private void btnElcetro_MouseEnter(object sender, EventArgs e)      //Курсор находится над кнопкой
        {
            btnElectro.ForeColor = Color.Black;
            btnElectro.BackColor = SystemColors.Control;
        }

        private void btnElectro_MouseLeave(object sender, EventArgs e) // Курсор вне кнопки
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

        private void btnProveritZadachi_MouseEnter(Object sender, EventArgs e)
        { 
            btnProveritZadachi.ForeColor= System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); ;
            btnProveritZadachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
        }

        private void btnProveritZadachi_MouseLeave(Object sender, EventArgs e)
        {
            this.btnProveritZadachi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnProveritZadachi.ForeColor = System.Drawing.Color.White;
        }

        //

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

        private void btnProveritZadachi_Click(Object sender, EventArgs e)
        {
            int i = 0; int j = 0;
            bool[] kakoi_pravilniy = new bool[10];  //Какой из ответов пользователя оказался верным. index: вопрос; value: true/false;

            for (i = 0; i < 10; i++)
                kakoi_pravilniy[i] = otvety_Zadachi[i] == otvety_User[i] ? true : false;


            rdBtn_1q_2v.ForeColor = Color.Green;
            rdBtn_2q_3v.ForeColor = Color.Green;
            rdBtn_3q_2v.ForeColor = Color.Green;
            rdBtn_4q_3v.ForeColor = Color.Green;
            rdBtn_5q_4v.ForeColor = Color.Green;
            rdBtn_6q_2v.ForeColor = Color.Green;
            rdBtn_7q_2v.ForeColor = Color.Green;
            rdBtn_8q_2v.ForeColor = Color.Green;
            rdBtn_9q_3v.ForeColor = Color.Green;
            rdBtn_10q_4v.ForeColor = Color.Green;

            for (i = 0; i < 10; i++)
            {
                if (kakoi_pravilniy[i]==false)
                {
                    switch(i)
                    {
                        case 0:
                                switch (otvety_User[0])
                                {
                                    case 1:
                                        rdBtn_1q_1v.ForeColor = Color.Red;
                                        rdBtn_1q_3v.ForeColor = Color.White;
                                        rdBtn_1q_4v.ForeColor = Color.White;
                                        break;

                                    case 3:
                                        rdBtn_1q_3v.ForeColor = Color.Red;
                                        rdBtn_1q_1v.ForeColor = Color.White;
                                        rdBtn_1q_4v.ForeColor = Color.White;
                                        break;

                                    case 4:
                                        rdBtn_1q_4v.ForeColor = Color.Red;
                                        rdBtn_1q_1v.ForeColor = Color.White;
                                        rdBtn_1q_3v.ForeColor = Color.White;
                                        break;
                            } break;

                        case 1:                            
                                switch (otvety_User[1])
                                {
                                    case 1:
                                        rdBtn_2q_1v.ForeColor = Color.Red;
                                        rdBtn_2q_2v.ForeColor = Color.White;
                                        rdBtn_2q_4v.ForeColor = Color.White;
                                        break;

                                    case 2:
                                        rdBtn_2q_2v.ForeColor = Color.Red;
                                        rdBtn_2q_1v.ForeColor = Color.White;
                                        rdBtn_2q_4v.ForeColor = Color.White;
                                        break;

                                    case 4:
                                        rdBtn_2q_4v.ForeColor = Color.Red;
                                        rdBtn_2q_1v.ForeColor = Color.White;
                                        rdBtn_2q_2v.ForeColor = Color.White;
                                        break;
                                } break;

                        case 2:
                            
                                switch (otvety_User[2])
                                {
                                    case 1:
                                        rdBtn_3q_1v.ForeColor = Color.Red;
                                        rdBtn_3q_3v.ForeColor = Color.White;
                                        rdBtn_3q_4v.ForeColor = Color.White;
                                        break;

                                    case 3:
                                        rdBtn_3q_3v.ForeColor = Color.Red;
                                        rdBtn_3q_1v.ForeColor = Color.White;
                                        rdBtn_3q_4v.ForeColor = Color.White;
                                        break;

                                    case 4:
                                        rdBtn_3q_4v.ForeColor = Color.Red;
                                        rdBtn_3q_1v.ForeColor = Color.White;
                                        rdBtn_3q_3v.ForeColor = Color.White;
                                        break;
                                } break;

                        case 3:
                            
                                switch (otvety_User[3])
                                {
                                    case 1:
                                        rdBtn_4q_1v.ForeColor = Color.Red;
                                        rdBtn_4q_3v.ForeColor = Color.White;
                                        rdBtn_4q_4v.ForeColor = Color.White;
                                        break;

                                    case 2:
                                        rdBtn_4q_3v.ForeColor = Color.Red;
                                        rdBtn_4q_1v.ForeColor = Color.White;
                                        rdBtn_4q_4v.ForeColor = Color.White;
                                        break;

                                    case 4:
                                        rdBtn_4q_4v.ForeColor = Color.Red;
                                        rdBtn_4q_1v.ForeColor = Color.White;
                                        rdBtn_4q_3v.ForeColor = Color.White;
                                        break;
                                } break;

                        case 4:
                            
                                switch (otvety_User[4])
                                {
                                    case 1:
                                    rdBtn_5q_1v.ForeColor = Color.Red;
                                    rdBtn_5q_2v.ForeColor = Color.White;
                                    rdBtn_5q_3v.ForeColor = Color.White;
                                    break;

                                    case 2:
                                    rdBtn_5q_2v.ForeColor = Color.Red;
                                    rdBtn_5q_1v.ForeColor = Color.White;
                                    rdBtn_5q_3v.ForeColor = Color.White;
                                    break;

                                    case 3:
                                    rdBtn_5q_3v.ForeColor = Color.Red;
                                    rdBtn_5q_1v.ForeColor = Color.White;
                                    rdBtn_5q_2v.ForeColor = Color.White;
                                    break;
                                } break;

                        case 5:
                            
                                switch (otvety_User[5])
                                {
                                    case 1:
                                    rdBtn_6q_1v.ForeColor = Color.Red;
                                    rdBtn_6q_3v.ForeColor = Color.White;
                                    rdBtn_6q_4v.ForeColor = Color.White;
                                    break;

                                    case 3:
                                    rdBtn_6q_3v.ForeColor = Color.Red;
                                    rdBtn_6q_1v.ForeColor = Color.White;
                                    rdBtn_6q_4v.ForeColor = Color.White;
                                    break;

                                    case 4:
                                    rdBtn_6q_4v.ForeColor = Color.Red;
                                    rdBtn_6q_1v.ForeColor = Color.White;
                                    rdBtn_6q_3v.ForeColor = Color.White;
                                    break;
                                } break;

                        case 6:
                            
                                switch (otvety_User[6])
                                {
                                    case 1:
                                    rdBtn_7q_1v.ForeColor = Color.Red;
                                    rdBtn_7q_3v.ForeColor = Color.White;
                                    rdBtn_7q_4v.ForeColor = Color.White;
                                    break;

                                    case 3:
                                    rdBtn_7q_3v.ForeColor = Color.Red;
                                    rdBtn_7q_1v.ForeColor = Color.White;
                                    rdBtn_7q_4v.ForeColor = Color.White;
                                    break;

                                    case 4:
                                    rdBtn_7q_4v.ForeColor = Color.Red;
                                    rdBtn_7q_1v.ForeColor = Color.White;
                                    rdBtn_7q_3v.ForeColor = Color.White;
                                    break;
                                } break;

                        case 7:
                            
                                switch (otvety_User[7])
                                {
                                    case 1:
                                    rdBtn_8q_1v.ForeColor = Color.Red;
                                    rdBtn_8q_3v.ForeColor = Color.White;
                                    rdBtn_8q_4v.ForeColor = Color.White;
                                    break;

                                    case 3:
                                    rdBtn_8q_3v.ForeColor = Color.Red;
                                    rdBtn_8q_1v.ForeColor = Color.White;
                                    rdBtn_8q_4v.ForeColor = Color.White;
                                    break;

                                    case 4:
                                    rdBtn_8q_4v.ForeColor = Color.Red;
                                    rdBtn_8q_1v.ForeColor = Color.White;
                                    rdBtn_8q_3v.ForeColor = Color.White;
                                    break;
                                } break;

                        case 8:
                            
                                switch (otvety_User[8])
                                {
                                    case 1:
                                    rdBtn_9q_1v.ForeColor = Color.Red;
                                    rdBtn_9q_2v.ForeColor = Color.White;
                                    rdBtn_9q_4v.ForeColor = Color.White;
                                    break;

                                    case 2:
                                    rdBtn_9q_2v.ForeColor = Color.Red;
                                    rdBtn_9q_1v.ForeColor = Color.White;
                                    rdBtn_9q_4v.ForeColor = Color.White;
                                    break;

                                    case 4:
                                    rdBtn_9q_4v.ForeColor = Color.Red;
                                    rdBtn_9q_1v.ForeColor = Color.White;
                                    rdBtn_9q_2v.ForeColor = Color.White;
                                    break;
                                } break;

                        case 9:
                            
                                switch (otvety_User[9])
                                {
                                    case 1:
                                    rdBtn_10q_1v.ForeColor = Color.Red;
                                    rdBtn_10q_2v.ForeColor = Color.White;
                                    rdBtn_10q_3v.ForeColor = Color.White;
                                    break;

                                    case 2:
                                    rdBtn_10q_2v.ForeColor = Color.Red;
                                    rdBtn_10q_1v.ForeColor = Color.White;
                                    rdBtn_10q_3v.ForeColor = Color.White;
                                    break;

                                    case 3:
                                    rdBtn_10q_3v.ForeColor = Color.Red;
                                    rdBtn_10q_1v.ForeColor = Color.White;
                                    rdBtn_10q_2v.ForeColor = Color.White;
                                    break;
                                } break;
                    }
                }
            }
        }

        //

        private int[] otvety_Zadachi = {2, 3, 2, 3, 4, 2, 2, 2, 3, 4 };     //Правильные ответы на тест. Индекс: вопрос, число: ответ
        private int[] otvety_User = new int[10] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };    //Ответы, которые дал пользователь; Первоначальные значения 0, 
                                                                                    //чтобы легче отследить, выбрал ли ползователь один из вариантов ответа

        private void rdBtn_1q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[0] = 1;
        }

        private void rdBtn_1q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[0] = 2;
        }

        private void rdBtn_1q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[0] = 3;
        }

        private void rdBtn_1q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[0] = 4;
        }

        private void rdBtn_2q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[1] = 1;
        }

        private void rdBtn_2q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[1] = 2;
        }

        private void rdBtn_2q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[1] = 3;
        }

        private void rdBtn_2q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[1] = 4;
        }

        private void rdBtn_3q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[2] = 1;
        }

        private void rdBtn_3q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[2] = 2;
        }

        private void rdBtn_3q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[2] = 3;
        }

        private void rdBtn_3q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[2] = 4;
        }

        private void rdBtn_4q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[3] = 1;
        }

        private void rdBtn_4q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[3] = 2;
        }

        private void rdBtn_4q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[3] = 3;
        }

        private void rdBtn_4q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[3] = 4;
        }

        private void rdBtn_5q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[4] = 1;
        }

        private void rdBtn_5q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[4] = 2;
        }
        private void rdBtn_5q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[4] = 3;
        }

        private void rdBtn_5q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[4] = 4;
        }

        private void rdBtn_6q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[5] = 1;
        }

        private void rdBtn_6q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[5] = 2;
        }

        private void rdBtn_6q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[5] = 3;
        }

        private void rdBtn_6q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[5] = 4;
        }

        private void rdBtn_7q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[6] = 1;
        }

        private void rdBtn_7q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[6] = 2;
        }

        private void rdBtn_7q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[6] = 3;
        }

        private void rdBtn_7q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[6] = 4;
        }

        private void rdBtn_8q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[7] = 1;
        }

        private void rdBtn_8q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[7] = 2;
        }

        private void rdBtn_8q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[7] = 3;
        }

        private void rdBtn_8q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[7] = 4;
        }

        private void rdBtn_9q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[8] = 1;
        }

        private void rdBtn_9q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[8] = 2;
        }

        private void rdBtn_9q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[8] = 3;
        }

        private void rdBtn_9q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[8] = 4;
        }

        private void rdBtn_10q_1v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[9] = 1;
        }

        private void rdBtn_10q_2v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[9] = 2;
        }

        private void rdBtn_10q_3v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[9] = 3;
        }

        private void rdBtn_10q_4v_CheckedChanged(object sender, EventArgs e)
        {
            otvety_User[9] = 4;
        }

    }
}
