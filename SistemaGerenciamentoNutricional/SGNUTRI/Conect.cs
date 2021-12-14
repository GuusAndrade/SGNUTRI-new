using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SGNUTRI
{
    static class Conect
    {
        static private string servidor = "us-cdbr-east-04.cleardb.com";
        static private string bancoDados = "heroku_ba59f508f074af3";
        static private string usuario = "b4c0c0c00ebaf9";
        static private string senha = "e6d4c5f6";

        static public string strConect = $"server={servidor}; User Id={usuario}; database={bancoDados}; password={senha}; Allow Zero Datetime=true";
    }

    public class Conexao
    {
        SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = "";

        }

       // public SqlConnection conectar()
        

        public void desconectar()
        {

        }
    }




}

