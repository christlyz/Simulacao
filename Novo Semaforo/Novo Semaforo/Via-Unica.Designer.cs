
namespace Novo_Semaforo
{
    partial class viaUnica
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viaUnica));
            this.picCarro = new System.Windows.Forms.PictureBox();
            this.picVerde = new System.Windows.Forms.PictureBox();
            this.picAmarelo = new System.Windows.Forms.PictureBox();
            this.picVermelho = new System.Windows.Forms.PictureBox();
            this.picPedestre = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnReinicia = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelFundo = new System.Windows.Forms.Panel();
            this.picFundo = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).BeginInit();
            this.panelTitulo.SuspendLayout();
            this.panelFundo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // picCarro
            // 
            this.picCarro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picCarro.Image = ((System.Drawing.Image)(resources.GetObject("picCarro.Image")));
            this.picCarro.Location = new System.Drawing.Point(476, 668);
            this.picCarro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picCarro.Name = "picCarro";
            this.picCarro.Size = new System.Drawing.Size(149, 172);
            this.picCarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCarro.TabIndex = 0;
            this.picCarro.TabStop = false;
            // 
            // picVerde
            // 
            this.picVerde.Image = ((System.Drawing.Image)(resources.GetObject("picVerde.Image")));
            this.picVerde.Location = new System.Drawing.Point(329, 288);
            this.picVerde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picVerde.Name = "picVerde";
            this.picVerde.Size = new System.Drawing.Size(204, 212);
            this.picVerde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVerde.TabIndex = 1;
            this.picVerde.TabStop = false;
            // 
            // picAmarelo
            // 
            this.picAmarelo.Image = ((System.Drawing.Image)(resources.GetObject("picAmarelo.Image")));
            this.picAmarelo.Location = new System.Drawing.Point(329, 288);
            this.picAmarelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAmarelo.Name = "picAmarelo";
            this.picAmarelo.Size = new System.Drawing.Size(204, 212);
            this.picAmarelo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAmarelo.TabIndex = 2;
            this.picAmarelo.TabStop = false;
            // 
            // picVermelho
            // 
            this.picVermelho.Image = ((System.Drawing.Image)(resources.GetObject("picVermelho.Image")));
            this.picVermelho.Location = new System.Drawing.Point(329, 287);
            this.picVermelho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picVermelho.Name = "picVermelho";
            this.picVermelho.Size = new System.Drawing.Size(204, 212);
            this.picVermelho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVermelho.TabIndex = 3;
            this.picVermelho.TabStop = false;
            // 
            // picPedestre
            // 
            this.picPedestre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picPedestre.Image = ((System.Drawing.Image)(resources.GetObject("picPedestre.Image")));
            this.picPedestre.Location = new System.Drawing.Point(312, 395);
            this.picPedestre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picPedestre.Name = "picPedestre";
            this.picPedestre.Size = new System.Drawing.Size(89, 103);
            this.picPedestre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPedestre.TabIndex = 4;
            this.picPedestre.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(325, 284);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Botão";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(325, 330);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cartão";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnReinicia
            // 
            this.btnReinicia.BackColor = System.Drawing.Color.White;
            this.btnReinicia.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReinicia.FlatAppearance.BorderSize = 2;
            this.btnReinicia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReinicia.ForeColor = System.Drawing.Color.Black;
            this.btnReinicia.Location = new System.Drawing.Point(957, 158);
            this.btnReinicia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReinicia.Name = "btnReinicia";
            this.btnReinicia.Size = new System.Drawing.Size(89, 41);
            this.btnReinicia.TabIndex = 8;
            this.btnReinicia.Text = "Reiniciar";
            this.btnReinicia.UseVisualStyleBackColor = false;
            this.btnReinicia.Click += new System.EventHandler(this.btnReinicia_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.Black;
            this.panelTitulo.Controls.Add(this.button3);
            this.panelTitulo.Controls.Add(this.button4);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(1061, 52);
            this.panelTitulo.TabIndex = 35;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(911, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 52);
            this.button3.TabIndex = 36;
            this.button3.Text = "_";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(989, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 52);
            this.button4.TabIndex = 35;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panelFundo
            // 
            this.panelFundo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFundo.Controls.Add(this.button2);
            this.panelFundo.Controls.Add(this.button1);
            this.panelFundo.Controls.Add(this.btnReinicia);
            this.panelFundo.Controls.Add(this.picVermelho);
            this.panelFundo.Controls.Add(this.picAmarelo);
            this.panelFundo.Controls.Add(this.picVerde);
            this.panelFundo.Controls.Add(this.picFundo);
            this.panelFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFundo.Location = new System.Drawing.Point(0, 0);
            this.panelFundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelFundo.Name = "panelFundo";
            this.panelFundo.Size = new System.Drawing.Size(1061, 673);
            this.panelFundo.TabIndex = 36;
            this.panelFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFundo_Paint_1);
            // 
            // picFundo
            // 
            this.picFundo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFundo.BackgroundImage")));
            this.picFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFundo.Location = new System.Drawing.Point(0, 0);
            this.picFundo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picFundo.Name = "picFundo";
            this.picFundo.Size = new System.Drawing.Size(1061, 673);
            this.picFundo.TabIndex = 4;
            this.picFundo.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // viaUnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 673);
            this.Controls.Add(this.picPedestre);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.picCarro);
            this.Controls.Add(this.panelFundo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viaUnica";
            this.Text = "Via Única";
            this.Activated += new System.EventHandler(this.viaUnica_Activated);
            this.Load += new System.EventHandler(this.viaUnica_Load);
            this.ResizeEnd += new System.EventHandler(this.viaUnica_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.viaUnica_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.viaUnica_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viaUnica_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCarro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAmarelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVermelho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPedestre)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelFundo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picCarro;
        private System.Windows.Forms.PictureBox picVerde;
        private System.Windows.Forms.PictureBox picAmarelo;
        private System.Windows.Forms.PictureBox picVermelho;
        private System.Windows.Forms.PictureBox picPedestre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnReinicia;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelFundo;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox picFundo;
    }
}