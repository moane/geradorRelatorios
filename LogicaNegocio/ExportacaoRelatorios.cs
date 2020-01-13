using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicaNegocio
{
    public class ExportacaoRelatorios
    {
        //Criar metodo generico de exportacao recebendo o tipo de arquivo

        public static void ExportarCSV(DataTable dt, string caminho, string nomeRelatorio)
        {
            StringBuilder sb = new StringBuilder();

            IEnumerable<string> columnNames = dt.Columns.Cast<DataColumn>().
                                              Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));

            foreach (DataRow row in dt.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }

            string arquivo = nomeRelatorio + " - " +  DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".csv";
            if (!Directory.Exists(caminho))
                Directory.CreateDirectory(caminho);
                        
            File.WriteAllText(caminho + "\\" + arquivo, sb.ToString());
        }

    }
}
