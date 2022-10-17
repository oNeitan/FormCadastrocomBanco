﻿using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ComandosBanco cmdbd = new ComandosBanco();
            cmdbd.cadastrar(txtbNome.Text, txtbCPF.Text, txtbEmail.Text, txtbTelefone.Text, txtbSenha.Text);

            MessageBox.Show(cmdbd.mensagem);
        }
    }
}
