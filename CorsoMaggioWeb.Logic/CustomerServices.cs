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
        public List<Customers> ListCustomers(string search = null) {

            IQueryable<Customers> data = DbContext.Customers;

            if (!String.IsNullOrEmpty(search))
            {
                data = data.Where(c => c.CustomerID == search || 
                            c.CompanyName.Contains(search) ||
                            c.ContactName.Contains(search) ||
                            c.Country.Contains(search) );
            }

            return data.ToList();
        }
    }
}
