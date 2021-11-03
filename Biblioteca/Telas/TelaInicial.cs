﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaLogin Forms = new TelaLogin();
            Forms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro Forms = new TelaCadastro();
            Forms.ShowDialog();
        }
    }
}
