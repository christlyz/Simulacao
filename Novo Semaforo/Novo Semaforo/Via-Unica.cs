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

namespace Novo_Semaforo
{
    public partial class viaUnica : Form
    {
        int caso = 0;
        public int tempo = 20;
        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.FromArgb(0, 0, 0);

        public viaUnica()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
            this.panelTitulo.BackColor = borderColor;
            this.button3.BackColor = borderColor;
            this.button4.BackColor = borderColor;
            this.BackColor = borderColor;

            picFundo.Controls.Add(picCarro);
            picCarro.BackColor = Color.Transparent;

            picFundo.Controls.Add(picPedestre);
            picPedestre.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVermelho);
            picVermelho.BackColor = Color.Transparent;

            picFundo.Controls.Add(picAmarelo);
            picAmarelo.BackColor = Color.Transparent;

            picFundo.Controls.Add(picVerde);
            picVerde.BackColor = Color.Transparent;
        }

        // Arrastar Form

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void viaUnica_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // Métodos Privados
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

        private void viaUnica_Paint(object sender, PaintEventArgs e)
        {
            FormRegionAndBorder(this, borderRadius, e.Graphics, borderColor, borderSize);
        }

        private void panelFundo_Paint_1(object sender, PaintEventArgs e)
        {
            ControlRegionAndBorder(panelFundo, borderRadius - (borderSize / 2), e.Graphics, borderColor);
        }

        private void viaUnica_Activated(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void viaUnica_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void viaUnica_ResizeEnd(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (caso)
            {
                //Tempos do Botão//
                case 1:
                    timer1.Interval = 2500;
                    caso = 2;
                    break;
                case 2:
                    picVerde.Visible = false;
                    picAmarelo.Visible = true;
                    timer1.Interval = 3000;
                    caso = 3;
                    break;
                case 3:
                    picAmarelo.Visible = false;
                    picVermelho.Visible = true;
                    timer1.Interval = 10000;
                    caso = 4;
                    break;
                case 4:
                    picVermelho.Visible = false;
                    picVerde.Visible = true;
                    timer3.Enabled = true;
                    caso = 0;
                    break;

                //Tempos do Cartão//
                case 5:
                    timer1.Interval = 3000;
                    caso = 6;
                    break;
                case 6:
                    picVerde.Visible = false;
                    picAmarelo.Visible = true;
                    timer1.Interval = 3000;
                    caso = 7;
                    break;
                case 7:
                    picAmarelo.Visible = false;
                    picVermelho.Visible = true;
                    timer1.Interval = 15000;
                    caso = 8;
                    break;
                case 8:
                    picVermelho.Visible = false;
                    picVerde.Visible = true;
                    caso = 0;
                    break;

            }
        }

        private void viaUnica_Load(object sender, EventArgs e)
        {
            picVerde.Visible = true;
            picVermelho.Visible = false;
            picAmarelo.Visible = false;

            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Botão")
            {
                timer1.Interval = 2500;
                caso = 1;
                tempo = 25;
            }
            else
            {
                caso = 0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if ((picAmarelo.Visible || picVermelho.Visible) == true && picCarro.Location.Y > 412)
            {
                picCarro.Top -= 1;
            }

            else if (picVerde.Visible == true || ((picAmarelo.Visible || picVermelho.Visible) == true && picCarro.Location.Y < 412))
            {
                picCarro.Top -= 2;
            }
            else if ((picAmarelo.Visible || picVermelho.Visible) == true && picCarro.Location.Y == 412)
            {
                picCarro.Top -= 0;
            }
            if (picVermelho.Visible == true || picPedestre.Location.X > 510 || picPedestre.Location.X <= 212)
            {
                picPedestre.Left += 1;
            }

            if (picCarro.Location.Y < -172)
                picCarro.Location = new Point(357, 531);

            if (picPedestre.Location.X > 879)
                picPedestre.Location = new Point(-67, 254);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            caso = 5;
        }

        private void btnReinicia_Click(object sender, EventArgs e)
        {
            picCarro.Location = new Point(357, 543);
            picPedestre.Location = new Point(234, 321);

            timer3.Enabled = false;
            button1.Text = "Botão";
            tempo = 25;

            if ((picVermelho.Visible || picAmarelo.Visible) == true)
            {
                picVerde.Visible = true;
                picAmarelo.Visible = false;
                picVermelho.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (tempo > 0)
            {
                tempo -= 1;
                button1.Text = tempo.ToString();
            }
            if (tempo == 0)
            {
                button1.Text = "Botão";
                timer3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
