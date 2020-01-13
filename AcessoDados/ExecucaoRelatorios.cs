using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessoDados
{
    public static class ExecucaoRelatorios
    {
        public static DataTable ExecutarRelatorio(string query)
        {
            DataTable dtRetorno = new DataTable(); 
          
            Acesso acesso = new Acesso();
            using (var da = new SqlDataAdapter(query, acesso.Conexao))
            {
                da.Fill(dtRetorno);
            }

            acesso.FecharConexao();

            return dtRetorno; 

        }
    }
}
