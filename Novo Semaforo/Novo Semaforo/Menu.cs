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

namespace Novo_Semaforo
{
    public partial class menu : Form
    {

        private int borderRadius = 30;
        private int borderSize = 2;
        private Color borderColor = Color.RoyalBlue;
        public menu()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Padding = new Padding(borderSize);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000;
                return cp;
            }
        }
        private void menu_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

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
            if(this.WindowState != FormWindowState.Minimized)
            {
                using (GraphicsPath roundPath = GetRoundedPath(form.ClientRectangle, radius))
                using (System.Drawing.Pen penBorder = new System.Drawing.Pen(borderColor, borderSize))
                using (Matrix tranform = new Matrix())
                {
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    form.Region = new Region(roundPath);
                    if(borderSize > 1)
                    {
                        Rectangle rect = form.ClientRectangle;
                        float scaleX = 1.0F - ((borderSize + 1) / rect.Width);
                        float scaleY = 1.0F - ((borderSize + 1) / rect.Height);

                        Transform.scale(scaleX, scaleY);
                        Transform.translate(borderSize / 1.6F, borderSize / 1.6F);

                        graph.Transform = tranform;
                        graph.DrawPath(penBorder, roundPath);
                    }
                }
            }
        }
        // Via Única //

        private void picViaUnica_MouseEnter(object sender, EventArgs e)
        {
            picViaUnica2.Visible = true;
        }

        private void picViaUnica1_MouseLeave(object sender, EventArgs e)
        {
            picViaUnica2.Visible = false;
        }

        private void picViaUnica2_Click(object sender, EventArgs e)
        {
            viaUnica vUnica = new viaUnica();
            vUnica.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            viaUnica vUnica = new viaUnica();
            vUnica.ShowDialog();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            picViaUnica2.Visible = true;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            picViaUnica2.Visible = false;
        }

        // Cruzamento //
        private void picCruzamento2_Click(object sender, EventArgs e)
        {
            Cruzamento cruzamento = new Cruzamento();
            cruzamento.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Cruzamento cruzamento = new Cruzamento();
            cruzamento.ShowDialog();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            picCruzamento2.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            picCruzamento2.Visible = false;
        }

        private void picCruzamento1_MouseEnter(object sender, EventArgs e)
        {
            picCruzamento2.Visible = true;
        }

        private void picCruzamento1_MouseLeave(object sender, EventArgs e)
        {
            picCruzamento2.Visible = false;
        }

    }
}