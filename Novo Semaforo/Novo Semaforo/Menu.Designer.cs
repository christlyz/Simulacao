
namespace Novo_Semaforo
{
    partial class menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnico = new System.Windows.Forms.Button();
            this.btnCruzamento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUnico
            // 
            this.btnUnico.Location = new System.Drawing.Point(504, 228);
            this.btnUnico.Name = "btnUnico";
            this.btnUnico.Size = new System.Drawing.Size(100, 41);
            this.btnUnico.TabIndex = 0;
            this.btnUnico.Text = "Via única";
            this.btnUnico.UseVisualStyleBackColor = true;
            this.btnUnico.Click += new System.EventHandler(this.btnUnico_Click);
            // 
            // btnCruzamento
            // 
            this.btnCruzamento.Location = new System.Drawing.Point(504, 275);
            this.btnCruzamento.Name = "btnCruzamento";
            this.btnCruzamento.Size = new System.Drawing.Size(100, 41);
            this.btnCruzamento.TabIndex = 1;
            this.btnCruzamento.Text = "Cruzamento";
            this.btnCruzamento.UseVisualStyleBackColor = true;
            this.btnCruzamento.Click += new System.EventHandler(this.btnCruzamento_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnCruzamento);
            this.Controls.Add(this.btnUnico);
            this.Name = "menu";
            this.Text = "Accessibility Way";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnico;
        private System.Windows.Forms.Button btnCruzamento;
    }
}

