using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;
using Matrix = System.Drawing.Drawing2D.Matrix;
using Pen = System.Drawing.Pen;

namespace Novo_Semaforo
{
    public partial class Cruzamento : Form
    {
        //Fields
        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(0, 0, 0);


        int caso = 0;
        int casoCartao = 0;
        int sequencia = 0;

        public Cruzamento()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitulo.BackColor = borderColor;
            this.button1.BackColor = borderColor;
            this.button3.BackColor = borderColor;
            this.BackColor = borderColor;

            picFundo.Controls.Add(picCarroPreto);
            picCarroPreto.BackColor = Color.Transparent;

            picFundo.Controls.Add(picCarroBranco);
            picCarroBranco.BackColor = Color.Transparent;

            picFundo.Controls.Add(picPedestre);
            picPedestre.BackColor = Color.Transparent;

            picFundo.Controls.Add(picCadeirante);
            picCadeirante.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVermelho1);
            picVermelho1.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVermelho2);
            picVermelho2.BackColor = Color.Transparent;

            picFundo.Controls.Add(picAmarelo1);
            picAmarelo1.BackColor = Color.Transparent;

            picFundo.Controls.Add(picAmarelo2);
            picAmarelo2.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVerde1);
            picVerde1.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVerde2);
            picVerde2.BackColor = Color.Transparent;
        }
        // Arrastar Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void Cruzamento_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Métodos privados
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void FormRegionAndBorder(Form form, float radius, Graphics graph, Color borderColor, float borderSize)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                using (Matrix transform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if (borderSize >= 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        transform.Scale(scaleX, scaleY);
                        transform.Translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = transform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }

        private void ControlRegionAndBorder(Control control, float radius, Graphics graph, Color borderColor)
        {
            using (GraphicsPath roundPath = GetRoundedPath(control.ClientRectangle, radius))
            using (Pen penBorder = new Pen(borderColor, 1))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                control.Region = new Region(roundPath);
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private void DrawPath(Rectangle rect, Graphics graph, Color color)
        {
            using (GraphicsPath roundPath = GetRoundedPath(rect, borderRadius))
            using (Pen penBorder = new Pen(color, 3))
            {
                graph.DrawPath(penBorder, roundPath);
            }
        }
        private struct FormBoundsColors
        {
            public Color TopLeftColor;
            public Color TopRightColor;
            public Color BottomLeftColor;
            public Color BottomRightColor;
        }
        private FormBoundsColors GetFormBoundsColors()
        {
            var fbColor = new FormBoundsColors();
            using (var bmp = new Bitmap(1, 1))
            using (Graphics graph = Graphics.FromImage(bmp))
            {
                Rectangle rectBmp = new Rectangle(0, 0, 1, 1);
                //Top Left
                rectBmp.X = this.Bounds.X - 1;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopLeftColor = bmp.GetPixel(0, 0);
                //Top Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Y;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.TopRightColor = bmp.GetPixel(0, 0);
                //Bottom Left
                rectBmp.X = this.Bounds.X;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomLeftColor = bmp.GetPixel(0, 0);
                //Bottom Right
                rectBmp.X = this.Bounds.Right;
                rectBmp.Y = this.Bounds.Bottom;
                graph.CopyFromScreen(rectBmp.Location, Point.Empty, rectBmp.Size);
                fbColor.BottomRightColor = bmp.GetPixel(0, 0);
            }
            return fbColor;
        }

        // Métodos de Eventos

        private void Cruzamento_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }
        private void panelFundo_Paint(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelFundo, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void Cruzamento_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Cruzamento_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Cruzamento_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
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
            if ((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y > 400)
            {
                picCarroPreto.Top -= 1;
            }
            else if (picVerde1.Visible == true || ((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y < 400))
            {
                picCarroPreto.Top -= 2;
            }
            else if ((picAmarelo1.Visible || picVermelho1.Visible) == true && picCarroPreto.Location.Y == 400)
            {
                picCarroPreto.Top -= 0;
            }


            if ((picAmarelo2.Visible || picVermelho2.Visible) == true && picCarroBranco.Location.X > 642)
            {
                picCarroBranco.Left -= 1;
            }
            else if (picVerde2.Visible == true || ((picAmarelo2.Visible || picVermelho2.Visible) == true && picCarroBranco.Location.X < 642))
            {
                picCarroBranco.Left -= 2;
            }
            else if ((picAmarelo2.Visible || picVermelho2.Visible) == true && picCarroBranco.Location.X == 642)
            {
                picCarroBranco.Left -= 0;
            }


            if (picVermelho1.Visible == true && picAmarelo2.Visible == false || picPedestre.Location.X < 128 || picPedestre.Location.X >= 358)
            {
                picPedestre.Left += 1;
            }
            if (picVermelho1.Visible == true && picVermelho2.Visible == true || picCadeirante.Location.Y < 14 || picCadeirante.Location.Y >= 245)
            {
                picCadeirante.Top += 1;
            }



            if (picCarroPreto.Location.Y < -133)
            {
                picCarroPreto.Location = new Point(241, 534);
            }
            else if (picCarroBranco.Location.X < -128)
            {
                picCarroBranco.Location = new Point(466, -15);
            }
            else if (picPedestre.Location.X >= 907)
            {
                picPedestre.Location = new Point(-95, 323);
            }
            else if (picCadeirante.Location.Y >= 638)
            {
                picCadeirante.Location = new Point(569, -52);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
            timer1.Enabled = false;
            casoCartao = 1;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            switch (casoCartao)
            {
                case 1:
                    if (picVerde1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;
                        sequencia = 1;
                    }
                    else if (picVerde2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;
                        sequencia = 2;
                    }
                    else if (picAmarelo1.Visible == true)
                    {
                        picVermelho1.Visible = false;
                        picAmarelo1.Visible = true;
                        picVerde1.Visible = false;

                        picVermelho2.Visible = true;
                        picAmarelo2.Visible = false;
                        picVerde2.Visible = false;

                        sequencia = 1;
                    }
                    else if (picAmarelo2.Visible == true)
                    {
                        picVermelho2.Visible = false;
                        picAmarelo2.Visible = true;
                        picVerde2.Visible = false;


                        picVermelho1.Visible = true;
                        picAmarelo1.Visible = false;
                        picVerde1.Visible = false;

                        sequencia = 2;
                    }
                    timer3.Interval = 3000;
                    casoCartao = 2;
                    break;

                case 2:
                    picVermelho1.Visible = true;
                    picVermelho2.Visible = true;
                    picAmarelo1.Visible = false;
                    picAmarelo2.Visible = false;

                    timer3.Interval = 5000;
                    casoCartao = 3;
                    break;
                case 3:

                    if (sequencia == 2)
                    {
                        picVerde1.Visible = true;
                        picVermelho1.Visible = false;
                    }
                    else if (sequencia == 1)
                    {
                        picVerde2.Visible = true;
                        picVermelho2.Visible = false;
                    }
                    timer3.Interval = 1;
                    timer1.Enabled = true;
                    casoCartao = 0;
                    caso = 0;
                    break;
                }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            picCadeirante.Location = new Point(466, 44);
            picPedestre.Location = new Point(135, 319);

            picCarroPreto.Location = new Point(241, 534);
            picCarroBranco.Location = new Point(785, 152);

            picVerde1.Visible = true;
            picVermelho2.Visible = true;

            picAmarelo1.Visible = false;
            picAmarelo2.Visible = false;
            picVermelho1.Visible = false;
            picVerde2.Visible = false;
            caso = 0;
        }
    }
}
