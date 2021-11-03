using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca.Conexao
{
    public class Conectar
    {
        SqlConnection con = new SqlConnection();

         public Conectar()
        {
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\guton\source\repos\Biblioteca\Biblioteca\dbBiblioteca.mdf;Integrated Security=True";
        }


        public SqlConnection conectando ()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectando()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
