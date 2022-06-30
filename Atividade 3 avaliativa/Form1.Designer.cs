namespace Atividade_3_avaliativa
{
    partial class Form1
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobreNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.pibGaloCego = new System.Windows.Forms.PictureBox();
            this.lblResultado1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pibGaloCego)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(48, 50);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblSobreNome
            // 
            this.lblSobreNome.AutoSize = true;
            this.lblSobreNome.Location = new System.Drawing.Point(51, 87);
            this.lblSobreNome.Name = "lblSobreNome";
            this.lblSobreNome.Size = new System.Drawing.Size(61, 13);
            this.lblSobreNome.TabIndex = 1;
            this.lblSobreNome.Text = "Sobrenome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(92, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(118, 84);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 3;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(143, 128);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 4;
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(48, 131);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(89, 13);
            this.lblDataNascimento.TabIndex = 5;
            this.lblDataNascimento.Text = "Data Nascimento";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(92, 180);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(109, 33);
            this.btnValidar.TabIndex = 7;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(28, 305);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(58, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado:";
            // 
            // pibGaloCego
            // 
            this.pibGaloCego.Image = global::Atividade_3_avaliativa.Properties.Resources.f0;
            this.pibGaloCego.Location = new System.Drawing.Point(266, 1);
            this.pibGaloCego.Name = "pibGaloCego";
            this.pibGaloCego.Size = new System.Drawing.Size(522, 450);
            this.pibGaloCego.TabIndex = 6;
            this.pibGaloCego.TabStop = false;
            // 
            // lblResultado1
            // 
            this.lblResultado1.AutoSize = true;
            this.lblResultado1.Location = new System.Drawing.Point(92, 305);
            this.lblResultado1.Name = "lblResultado1";
            this.lblResultado1.Size = new System.Drawing.Size(35, 13);
            this.lblResultado1.TabIndex = 9;
            this.lblResultado1.Text = "label1";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(92, 219);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(109, 32);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.Location = new System.Drawing.Point(92, 257);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(109, 34);
            this.btnFECHAR.TabIndex = 11;
            this.btnFECHAR.Text = "FECHAR";
            this.btnFECHAR.UseVisualStyleBackColor = true;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblResultado1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.pibGaloCego);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSobreNome);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pibGaloCego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobreNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.PictureBox pibGaloCego;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblResultado1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFECHAR;
    }
}

