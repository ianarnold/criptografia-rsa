using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Envia
{
    public partial class Form1 : Form
    {
        ChaveAssimetrica key;
        public Form1()
        {
            InitializeComponent();
            key = new ChaveAssimetrica();
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            string frase, fraseCripto;
            frase = txtCriptografia.Text;
            fraseCripto = key.encrypt(frase);
            rchTxtResultado.Text = fraseCripto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rchTxtResultado.Text == "")
            {
                MessageBox.Show("Criptografe alguma mensagem");
            } else
            {
                string fraseDescrip, fraseCripto;
                fraseCripto = rchTxtResultado.Text;
                fraseDescrip = key.decrypt(fraseCripto);
                txtDescriptografia.Text = fraseDescrip;
            }
            
        }
    }
}
