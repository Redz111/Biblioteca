using Biblioteca.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Controle
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";

        public bool acessar (String login, String senha)
        {
            ControleLogin loginC = new ControleLogin();
            tem = loginC.verificaLogin(login, senha);
            if (!loginC.mensagem.Equals(""))
            {
                this.mensagem = loginC.mensagem;
            }
            return tem;

        }

        public String cadastrar(String nome, String email, String senha, String confsenha)
        {
            return mensagem;
        }
    }
}
