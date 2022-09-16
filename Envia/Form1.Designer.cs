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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbSimetrica = new System.Windows.Forms.RadioButton();
            this.rdbAssimetrica = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChave = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Location = new System.Drawing.Point(19, 155);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(333, 32);
            this.btnCriptografar.TabIndex = 0;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // txtCriptografia
            // 
            this.txtCriptografia.Location = new System.Drawing.Point(151, 90);
            this.txtCriptografia.Name = "txtCriptografia";
            this.txtCriptografia.Size = new System.Drawing.Size(201, 20);
            this.txtCriptografia.TabIndex = 1;
            // 
            // rchTxtResultado
            // 
            this.rchTxtResultado.Enabled = false;
            this.rchTxtResultado.Location = new System.Drawing.Point(20, 202);
            this.rchTxtResultado.Name = "rchTxtResultado";
            this.rchTxtResultado.Size = new System.Drawing.Size(332, 201);
            this.rchTxtResultado.TabIndex = 3;
            this.rchTxtResultado.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 424);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Descriptografar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDescriptografia
            // 
            this.txtDescriptografia.Enabled = false;
            this.txtDescriptografia.Location = new System.Drawing.Point(139, 475);
            this.txtDescriptografia.Name = "txtDescriptografia";
            this.txtDescriptografia.Size = new System.Drawing.Size(213, 20);
            this.txtDescriptografia.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto a ser criptografado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 478);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Texto descriptografado:";
            // 
            // rdbSimetrica
            // 
            this.rdbSimetrica.AutoSize = true;
            this.rdbSimetrica.Location = new System.Drawing.Point(151, 32);
            this.rdbSimetrica.Name = "rdbSimetrica";
            this.rdbSimetrica.Size = new System.Drawing.Size(68, 17);
            this.rdbSimetrica.TabIndex = 8;
            this.rdbSimetrica.TabStop = true;
            this.rdbSimetrica.Text = "Simétrica";
            this.rdbSimetrica.UseVisualStyleBackColor = true;
            this.rdbSimetrica.CheckedChanged += new System.EventHandler(this.rdbSimetrica_CheckedChanged);
            // 
            // rdbAssimetrica
            // 
            this.rdbAssimetrica.AutoSize = true;
            this.rdbAssimetrica.Location = new System.Drawing.Point(274, 32);
            this.rdbAssimetrica.Name = "rdbAssimetrica";
            this.rdbAssimetrica.Size = new System.Drawing.Size(78, 17);
            this.rdbAssimetrica.TabIndex = 9;
            this.rdbAssimetrica.TabStop = true;
            this.rdbAssimetrica.Text = "Assimétrica";
            this.rdbAssimetrica.UseVisualStyleBackColor = true;
            this.rdbAssimetrica.CheckedChanged += new System.EventHandler(this.rdbAssimetrica_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tipo de chave:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chave de criptografia:";
            // 
            // txtChave
            // 
            this.txtChave.Location = new System.Drawing.Point(151, 120);
            this.txtChave.Name = "txtChave";
            this.txtChave.Size = new System.Drawing.Size(201, 20);
            this.txtChave.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 520);
            this.Controls.Add(this.txtChave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbAssimetrica);
            this.Controls.Add(this.rdbSimetrica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbSimetrica;
        private System.Windows.Forms.RadioButton rdbAssimetrica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChave;
    }
}

