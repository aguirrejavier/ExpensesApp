using ExpensesApp.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain.Interface.Repositorys
{
    public interface IRepositoryUser<T,TId> : IAdd<T>, IModify<T>, IDelete<TId>, IList<T,TId>
    {
        public void GuardarCambios();
    }
}
