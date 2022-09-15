namespace Envia
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
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.txtCriptografia = new System.Windows.Forms.TextBox();
            this.rchTxtResultado = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDescriptografia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(13, 41);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(201, 115);
            this.btnCriptografar.TabIndex = 0;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // txtCriptografia
            // 
            this.txtCriptografia.Location = new System.Drawing.Point(13, 15);
            this.txtCriptografia.Name = "txtCriptografia";
            this.txtCriptografia.Size = new System.Drawing.Size(201, 20);
            this.txtCriptografia.TabIndex = 1;
            // 
            // rchTxtResultado
            // 
            this.rchTxtResultado.Enabled = false;
            this.rchTxtResultado.Location = new System.Drawing.Point(220, 15);
            this.rchTxtResultado.Name = "rchTxtResultado";
            this.rchTxtResultado.Size = new System.Drawing.Size(426, 141);
            this.rchTxtResultado.TabIndex = 3;
            this.rchTxtResultado.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(633, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Descriptografar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescriptografia
            // 
            this.txtDescriptografia.Enabled = false;
            this.txtDescriptografia.Location = new System.Drawing.Point(13, 260);
            this.txtDescriptografia.Name = "txtDescriptografia";
            this.txtDescriptografia.Size = new System.Drawing.Size(633, 20);
            this.txtDescriptografia.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 413);
            this.Controls.Add(this.txtDescriptografia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchTxtResultado);
            this.Controls.Add(this.txtCriptografia);
            this.Controls.Add(this.btnCriptografar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCriptografar;
        private System.Windows.Forms.TextBox txtCriptografia;
        private System.Windows.Forms.RichTextBox rchTxtResultado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescriptografia;
    }
}

