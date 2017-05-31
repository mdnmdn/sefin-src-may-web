using CorsoMaggioWeb.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoMaggioWeb.Logic
{
    public class CustomerServices : BaseServices
    {
        public List<Customers> ListCustomers() {
            return DbContext.Customers.ToList();
        }
    }
}
