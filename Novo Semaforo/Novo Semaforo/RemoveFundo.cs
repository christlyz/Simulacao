using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novo_Semaforo
{
    public class RemoveFundo : PictureBox
    {
        private int backgroundTop
        public RemoveFundo(PictureBox background, Image myImage) : base()
        {
            this.Image = myImage;
            base.Image = myImage;


        }
    }
}
