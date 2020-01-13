using AcessoDados.Entity;
using AcessoDados.Entity.Models;
using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class ExecucaoRelatorios
    {
        public static void ExecutarRelatorios(string caminhoArquivoConfig)
        {
            List<ConfiguracaoRelatorio> configuracaoRelatorios = ConfiguracaoRelatorios.ObtenerConfiguracoes(caminhoArquivoConfig);

            //if configuracaoRelatorios = null - arqquivo conexao nao encontrado 

            foreach (var item in configuracaoRelatorios)
            {
                DataTable dtRelatorio = AcessoDados.ExecucaoRelatorios.ExecutarRelatorio(item.ConsultaSql);

                if(dtRelatorio.Rows.Count > 0)
                {
                    ExportacaoRelatorios.ExportarCSV(dtRelatorio, item.CaminhoArquivo, item.Nome);

                    //Gravando LOG no banco de dados
                    AcessoDados.LogExecucoes.GravarLogExecucao(item.Nome, item.ConsultaSql);
                    
                }
                //else salvar log

            }
           
        }
       


    }
}
