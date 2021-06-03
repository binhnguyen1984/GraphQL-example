using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using HotChocolate.Data;
using Microsoft.EntityFrameworkCore;
using northwinddb.Context;
using System.Threading;
using System.Threading.Tasks;

namespace GraphQlApi.QueryTypes
{
    public partial class Query
    {
        [UseProjection]
        [UseFiltering]
        public async Task<IQueryable<northwinddb.Models.Customer>> GetCustomers
        ([Service] IDbContextFactory<NorthWindDBContext> contextFactory,
         CancellationToken cancellationToken)
        {
            return (await contextFactory.CreateDbContext().Customers.ToListAsync(cancellationToken)).AsQueryable();
        }
        
    }
}