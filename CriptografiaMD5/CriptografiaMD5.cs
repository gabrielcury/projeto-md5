using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CriptografiaMD5
{
    public partial class CriptografiaMD5 : Form
    {
        public CriptografiaMD5()
        {
            InitializeComponent();
        }

        private void bt_Encrypt_Click(object sender, EventArgs e)
        {
            txtResultCrypt.Text = MD5Crypt.Criptografar(txtToCript.Text);
        }

        private void bt_Decrypt_Click(object sender, EventArgs e)
        {
            try
            {
                txtResultDecrypt.Text = MD5Crypt.Descriptografar(txtToCript.Text);
            }
            catch
            {
                MessageBox.Show("O valor informado para Decriptação é inválido.", "Encrypt");
            }            
        }
    }
}
