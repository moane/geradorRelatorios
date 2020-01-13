using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LogicaNegocio.Entidades
{
    [Serializable]
    public class ConfiguracaoRelatorio
    {
        public string Nome { get; set; }
        public string CaminhoConsulta { get; set; }
        public string CaminhoArquivo { get; set; }
        public DateTime DataHoraExecucao { get; set; }

        [XmlIgnore]
        public string ConsultaSql { get; set; }
    }
      
}
