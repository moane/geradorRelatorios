using AcessoDados.Entity;
using AcessoDados.Entity.Models;
using System;

namespace AcessoDados
{
    public class LogExecucoes
    {
        public static void GravarLogExecucao(string nomeRelatorio, string consulta)
        {
            LogExecucao log = new LogExecucao
            {
                NomeRelatorio = nomeRelatorio,
                DataHora = DateTime.Now,
                Consulta = consulta
            };

            using (var context = new AutomoveisContext())
            {
                context.LogExecucao.Add(log);
                context.SaveChanges();
            }                       
        }
    }
}
