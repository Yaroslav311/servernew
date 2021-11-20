using Microsoft.EntityFrameworkCore;
using PS_server.Access.Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS_server.Access.Data.Core.Interfaces.DbcContext
{
    public interface IRubicContext : IDisposable, IAsyncDisposable
    {
    DbSet<UserRto> Users { get; set; }
    DbSet<UserRoleRto> UserRoles { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
