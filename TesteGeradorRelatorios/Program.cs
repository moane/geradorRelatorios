using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteGeradorRelatorios
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            try
            {
                string caminhoArquivoConfig = ConfigurationManager.AppSettings["ArquivoConfiguracao"];

                LogicaNegocio.ExecucaoRelatorios.ExecutarRelatorios(caminhoArquivoConfig);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
            
            Console.ReadLine();
            
        }

        
    }
}
