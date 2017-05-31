using CorsoMaggioWeb.Logic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorsoMaggioWeb.Logic
{
    public class ProductServices : BaseServices
    {
        public List<Products> ListProducts() {
            return DbContext.Products.ToList();
        }
    }
}
