using System.Linq;
using HotChocolate;

namespace GraphQlApi.QueryTypes
{
    public partial class Query
    {
       public IQueryable<northwinddb.Models.Employee> GetEmployees([Service]northwinddb.Context.NorthWindDBContext dBContext)
       {
           return dBContext.Employees.AsQueryable();
       }
    }
}