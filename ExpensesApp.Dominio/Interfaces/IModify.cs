using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain.Interfaces
{
    public interface IModify<T>
    {
        public void Modify(T entity);
    }
}
