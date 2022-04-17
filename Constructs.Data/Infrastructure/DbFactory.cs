using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructs.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ConstructsDbContext dbContext;

        public ConstructsDbContext Init()
        {
            return dbContext ?? (dbContext = new ConstructsDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
