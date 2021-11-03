using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Conexao
{
    class ControleLogin
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        Conectar con = new Conectar();
        SqlDataReader dr;

        public bool verificaLogin (String login, String senha)
        {
            cmd.CommandText = "select * from logins where email = @login and senha = @senha";
            cmd.Parameters.AddWithValue("@login", login);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectando();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {

                this.mensagem = "Erro: DataBase";
            }
            return tem;
        }

        public String cadastrar (String email, String senha, String confSenha)
        {   

            return mensagem;
        }
    }
}
