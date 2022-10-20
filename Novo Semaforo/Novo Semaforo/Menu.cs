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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
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