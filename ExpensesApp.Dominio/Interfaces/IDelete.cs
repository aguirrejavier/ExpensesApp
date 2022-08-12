using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain.Interfaces
{
    public interface IDelete<TId>
    {
        public void Delete(TId entity);
    }
}
