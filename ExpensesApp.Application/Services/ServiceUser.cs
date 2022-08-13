using ExpensesApp.Application.Interfaces;
using ExpensesApp.Domain;
using ExpensesApp.Domain.Interface.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Services
{
    public class ServiceUser : IServiceUser<User, int>
    {
        private readonly IRepositoryUser<User, int> repositoryUser;

        public ServiceUser(IRepositoryUser<User, int> _repositoryUser)
        {
            repositoryUser = _repositoryUser;
        }
        public User Add(User entity)
        {
            if (entity == null)
                return null;
            var usuario = repositoryUser.Add(entity);
            repositoryUser.GuardarCambios();
            return usuario;
        }

        public void Delete(int entity)
        {
            repositoryUser.Delete(entity);
            repositoryUser.GuardarCambios();
        }

        public void LoginUser(User entity)
        {
            throw new NotImplementedException();
        }

        public void Modify(User entity)
        {
            if (entity == null)
                throw new NotImplementedException();
            repositoryUser.Modify(entity);
            repositoryUser.GuardarCambios();
        }
    }
}
