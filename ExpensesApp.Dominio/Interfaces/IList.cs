using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain.Interfaces
{
    public interface IList<T,TId>
    {
        public List<T> ListAll();
        public T GetById(TId id);
    }
}
