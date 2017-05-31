using CorsoMaggioWeb.Logic.Model;
using System;

namespace CorsoMaggioWeb.Logic
{
    public class BaseServices :IDisposable
    {
        NorthwindContext _dbContext;

        protected NorthwindContext DbContext {
            get { return _dbContext ?? (_dbContext = new NorthwindContext()); }
        }




        public void Dispose()
        {
            if (_dbContext != null)
                _dbContext.Dispose();
        }
    }
}