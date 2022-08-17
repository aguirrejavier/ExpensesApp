using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain.Interfaces
{
    public interface IAdd<T>
    {
        public void Add(T entity);
    }
}
