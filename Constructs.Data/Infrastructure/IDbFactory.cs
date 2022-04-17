using System;

namespace Constructs.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ConstructsDbContext Init();
    }
}