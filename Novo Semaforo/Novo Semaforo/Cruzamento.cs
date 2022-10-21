using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Semaforo
{
    public partial class Cruzamento : Form
    {
        int caso = 0;
        public Cruzamento()
        {
            InitializeComponent();
        }

        private void Cruzamento_Load(object sender, EventArgs e)
        {
            picVerde1.Visible = true;
            picVerde2.Visible = false;

            picAmarelo1.Visible = false;
            picAmarelo2.Visible = false;

            picVermelho1.Visible = false;
            picVermelho2.Visible = true;

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                case 0:
                    timer1.Interval = 5000;
                    caso = 1;
                    break;
                case 1:
                    if (picVerde1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;
                    }
                    else if (picVerde2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;
                    }
                    timer1.Interval = 4000;
                    caso = 2;
                    break;
                case 2:
                    if (picAmarelo1.Visible == true)
                    {
                        picVermelho1.Visible = true;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = false;

                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = true;
                    }
                    else if (picAmarelo2.Visible == true)
                    {
                        picVermelho2.Visible = true;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = false;


                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = true;
                    }
                    timer1.Interval = 8000;
                    caso = 3;
                    break;
                case 3:
                    timer1.Interval = 1;
                    caso = 0;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (picVermelho1.Visible == true && picVermelho2.Visible == true)
            {
                picCadeirante.Top += 1;
                picPedestre.Left += 1;
            }
            if (picAmarelo1.Visible)
            {
                picCarroPreto.Top -= 2;
            }
            else if (picAmarelo2.Visible)
            {
                picCarroBranco.Left -= 2;
            }

            if (picVermelho1.Visible == true && picCarroPreto.Location.Y <= 455 && picCarroPreto.Location.Y > 450)
            {
                picCarroPreto.Top -= 0;
            }
            else if ((picVerde1.Visible == true && picVermelho2.Visible == true) || picVermelho1.Visible == true && (picCarroPreto.Location.Y > 469 || picCarroPreto.Location.Y <= 450))
            {
                picCarroPreto.Top -= 3;
            }

            if (picVermelho2.Visible == true && picCarroBranco.Location.X <= 851 && picCarroBranco.Location.X > 895)
            {
                picCarroBranco.Left -= 0;
            }
            else if ((picVerde2.Visible == true && picVermelho1.Visible == true) || (picVermelho1.Visible && picVermelho2.Visible) == true && (picCarroBranco.Location.X > 851 || picCarroBranco.Location.X < 865))
            {
                picCarroBranco.Left -= 3;
                picPedestre.Left += 1;
            }

            if (picCarroPreto.Location.Y < -133)
            {
                picCarroPreto.Location = new Point(picVerde1.Location.X, 666);
            }
            else if (picCarroBranco.Location.X < -128)
            {
                picCarroBranco.Location = new Point(1053, picVerde2.Location.Y);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            picVermelho1.Visible = true;
            picAmarelo1.Visible = false;
            picVerde1.Visible = false;

            picVermelho2.Visible = true;
            picAmarelo2.Visible = false;
            picVerde2.Visible = false;
        }
    }
}
