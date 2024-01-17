using AgendaWeb.Infra.Data.Entities;
using AgendaWeb.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaWeb.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Create(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public Usuario GetByEmailESenha(string email, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
