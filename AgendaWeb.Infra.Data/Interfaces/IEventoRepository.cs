using AgendaWeb.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Interfaces
{
    /// <summary>
    /// Interface e repositorio para a entidade Evento
    /// </summary>
    public interface IEventoRepository : IBaseRepository<Evento>
    {
        /// <summary>
        /// Método para retornar toos os eventos dentro de um período de datas
        /// </summary>
        /// <param name="dataMin">Data de início doperíodo</param>
        /// <param name="dataMax">Data de término do período</param>
        /// <returns>Lista de Eventos</returns>
        List<Evento> GetByDatas(DateTime dataMin, DateTime dataMax);
    }
}
