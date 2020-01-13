using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public class Acesso
    {
        private string Server { get; set; }
        private string DataBase { get; set; }
        private string User { get; set; }
        private string Password { get; set; }

        //public static readonly string CONN_STRING = ConfigurationManager.ConnectionStrings["ConexaoBD"].ConnectionString;

        public SqlConnection Conexao { get; set; }
        public static object ConfigurationManager { get; private set; }

        public Acesso()
        {
            //Data Source = localhost\sqlexpress; Initial Catalog = myDataBase; Integrated Security = True;

            Server = "DESKTOP-DKDO5QL\\SQLEXPRESS";
            DataBase = "dbAutomoveis";
            User = "";
            Password = "qwe@123";
            CriarConexao();
        }

        public void CriarConexao()
        {
            string str = @"Data Source=DESKTOP-DKDO5QL\SQLEXPRESS;Initial Catalog=dbAutomoveis;Integrated Security=True";
            string stringConexao = "Data Source=" + Server + ";Initial Catalog = " + DataBase + ";Connect Timeout=30;User Id=" + User + ";Password=" + Password + ";";
            Conexao = new SqlConnection(str);
        }
        public void AbrirConexao()
        {
            if (Conexao.State != ConnectionState.Open)
                Conexao.Open();
        }
        public void FecharConexao()
        {
            Conexao.Close();
        }
    }
}
