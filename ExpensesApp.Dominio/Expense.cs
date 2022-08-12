using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesApp.Domain
{
    public class Expense
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public double Price { get; set; }
        public bool IsPaid { get; set; }
        public List<Category> IdCategory { get; set; }
        public List<User> IdUser { get; set; }

    }
}
