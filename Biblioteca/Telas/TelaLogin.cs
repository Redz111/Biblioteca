using System;
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
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelaCadastro Forms = new TelaCadastro();
            Forms.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txbLogin.Text, txbSenha.Text);
            if (controle.mensagem.Equals(""))
            {

                if (controle.tem)
                {
                    MessageBox.Show("Login efetuado com Sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TelaAcesso TA = new TelaAcesso();
                    TA.Show();
                }
                else
                {
                    MessageBox.Show("Login ou Senha Incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
