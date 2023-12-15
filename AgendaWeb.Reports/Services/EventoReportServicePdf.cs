using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Reports.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Reports.Services
{
    /// <summary>
    /// Classe para geração do relatório em formato PDF
    /// </summary>
    public class EventoReportServicePdf : IEventoReportService
    {
        /// <summary>
        /// Método para geração do relatório
        /// </summary>
        /// <param name="dataMin">Data de inicio da pesquisa</param>
        /// <param name="dataMax">Data de fim da pesquisa</param>
        /// <param name="eventos">Lista de eventos</param>
        /// <returns>Arquivo em formato byte</returns>
        public byte[] Create(DateTime dataMin, DateTime dataMax, List<Evento> eventos)
        {
            throw new NotImplementedException();
        }
    }
}
