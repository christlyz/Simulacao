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

        private void btnUnico_Click(object sender, EventArgs e)
        {
            viaUnica vUnica = new viaUnica();
            vUnica.ShowDialog();
        }

        private void btnCruzamento_Click(object sender, EventArgs e)
        {
            Cruzamento cruzamento = new Cruzamento();
            cruzamento.ShowDialog();
        }
    }
}
