using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Envia
{
    public partial class Form1 : Form
    {
        ChaveAssimetrica keyAss;
        ChaveSimetrica keySi;
        public Form1()
        {
            InitializeComponent();
            keyAss = new ChaveAssimetrica();
            keySi = new ChaveSimetrica();
            txtChave.Visible = false;
            label4.Visible = false;
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            rchTxtResultado.Text = "";
            if (!rdbSimetrica.Checked && !rdbAssimetrica.Checked)
            {
                MessageBox.Show("Selecione um tipo de chave para a criptografia.");
            } 
            else if (rdbSimetrica.Checked)
            {
                txtChave.Visible = true;
                label4.Visible = true;
                string frase, frasecripto, chave;
                frase = txtCriptografia.Text;
                chave = txtChave.Text;
                frasecripto = keySi.EncryptAesManaged(frase);
                rchTxtResultado.Clear();
                rchTxtResultado.Text = frasecripto;
            } 
            else if (rdbAssimetrica.Checked)
            {
                txtChave.Visible = false;
                label4.Visible = false;
                string frase, fraseCripto;
                frase = txtCriptografia.Text;
                fraseCripto = keyAss.encrypt(frase);
                rchTxtResultado.Text = fraseCripto;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rchTxtResultado.Text == "")
            {
                MessageBox.Show("Criptografe alguma mensagem");
            }
            else if(rdbSimetrica.Checked)
            {
                string fraseDescrip, frasecripto, texto;
                texto = txtCriptografia.Text;
                frasecripto = rchTxtResultado.Text;
                fraseDescrip = keySi.DecryptText(texto);
                txtDescriptografia.Text = fraseDescrip;
            }
            else if (rdbAssimetrica.Checked)
            {
                string fraseDescrip, fraseCripto;
                fraseCripto = rchTxtResultado.Text;
                fraseDescrip = keyAss.decrypt(fraseCripto);
                txtDescriptografia.Text = fraseDescrip;
            }
            
        }

        private void rdbSimetrica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSimetrica.Checked)
            {
                txtChave.Visible = true;
                label4.Visible = true;
            }
            else if (rdbAssimetrica.Checked)
            {
                txtChave.Visible = false;
                label4.Visible = false;
            }
        }
        private void rdbAssimetrica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSimetrica.Checked)
            {
                txtChave.Visible = true;
                label4.Visible = true;
            }
            else if (rdbAssimetrica.Checked)
            {
                txtChave.Visible = false;
                label4.Visible = false;
            }
        }
    }   
    }
