using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CryptIt
{
    public partial class Form1 : Form
    {
        private Crypt crypttool;

        public Form1()
        {
            InitializeComponent();
            crypttool = new Crypt();
        }

        private void btn_encrypt_Click(object sender, EventArgs e)
        {
            tb_output.Text = crypttool.encrypt(tb_input.Text, (int)num_cryptkey.Value);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            tb_output.Text = crypttool.decrypt(tb_input.Text, (int)num_cryptkey.Value);
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            tb_input.Text = tb_output.Text;
        }
    }
}
