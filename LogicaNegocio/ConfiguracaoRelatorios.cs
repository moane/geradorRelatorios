using LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicaNegocio
{
    public class ConfiguracaoRelatorios
    {
        public static List<ConfiguracaoRelatorio> ObtenerConfiguracoes(string caminhoArquivoConfig)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(List<ConfiguracaoRelatorio>));

            List<ConfiguracaoRelatorio> listaConfiguracoes = null;

            if (File.Exists(caminhoArquivoConfig))
            {
                using (TextReader Reader = new StreamReader(caminhoArquivoConfig))
                {
                    listaConfiguracoes = Serializer.Deserialize(Reader) as List<ConfiguracaoRelatorio>;
                    Reader.Close();
                }

                foreach (var config in listaConfiguracoes)
                {
                    if (File.Exists(config.CaminhoConsulta))
                    {
                        // Read entire text file content in one string  
                        string text = File.ReadAllText(config.CaminhoConsulta);
                        config.ConsultaSql = text;
                    }
                }
            }

            return listaConfiguracoes;

        }
    }
}
