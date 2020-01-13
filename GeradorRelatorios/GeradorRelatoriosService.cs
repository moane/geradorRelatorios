using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GeradorRelatorios
{
    public partial class GeradorRelatoriosService : ServiceBase
    {
        public GeradorRelatoriosService()
        {
            InitializeComponent();
        }

        private Timer _timer;

        protected override void OnStart(string[] args)
        {
           // note que ele está chamando um método CriarLog de 2 em 2 minutos
            _timer = new Timer(CriarLog, null, 0, 120000);

        }

        protected override void OnStop()
        {
            StreamWriter vWriter = new StreamWriter(@"C:\Logs\log.txt", true);

            vWriter.WriteLine("Servico Parado: " + DateTime.Now.ToString());
            vWriter.Flush();
            vWriter.Close();
        }

        private void CriarLog(object state)
        {
            StreamWriter vWriter = new StreamWriter(@"C:\Logs\log.txt", true);
            vWriter.WriteLine("inicio" + ": " + DateTime.Now);
            vWriter.Flush();
            vWriter.Close();
        }


    }
}
