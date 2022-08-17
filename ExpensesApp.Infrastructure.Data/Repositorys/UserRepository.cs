using ExpensesApp.Domain;
using ExpensesApp.Domain.Interface.Repositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Infrastructure.Data.Repositorys
{
    public class UserRepository : IRepositoryUser<User, int>
    {
        private ExpensesContext context;

        public UserRepository(ExpensesContext context)
        {
            this.context = context;
        }

        public void Add(User entity)
        {
            context.User.Add(entity);
        }

        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User SaveChanges()
        {
            context.SaveChanges();
            var usuario = new User();
            usuario.Id = 1;
            return usuario;
        }

        public List<User> ListAll()
        {
            throw new NotImplementedException();
        }

        public void Modify(User entity)
        {
            throw new NotImplementedException();
        }

    }
}
