using ExpensesApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Application.Interfaces
{
    public interface IServiceUser<T,TId> : IModify<T>, IDelete<TId>
    {
        public void LoginUser (T entity);
        public T RegisterUser(T entity);
    }
}
