using Microsoft.EntityFrameworkCore;
using PS_server.Access.Data.Core.Interfaces.DbcContext;
using PS_server.Access.Data.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PS_serveer.Access.Data.DbContext
{
    public class RubicConext : Microsoft.EntityFrameworkCore.DbContext, IRubicContext
    {
        public RubicConext(DbContextOptions<RubicConext> options)
            :base(options)
        {
        }

        public DbSet<UserRto> Users { get ; set; }
        public DbSet<UserRoleRto> UserRoles { get; set; }


    }
}
