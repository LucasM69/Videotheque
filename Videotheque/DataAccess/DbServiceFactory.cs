using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videotheque.DataAccess
{
    class DbServiceFactory : IDesignTimeDbContextFactory<DbService>
    {
        public DbService CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DbService>();
            optionsBuilder.UseSqlite("Data Source=database.db");

            return new DbService(optionsBuilder.Options);
        }
    }
}
