using Microsoft.Extensions.DependencyInjection;
using HotChocolate;
using GraphQlApi.QueryTypes;
using GraphQlApi.Types;

namespace GraphQlApi.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddMyGraphQlServer(this IServiceCollection services)
        {
             services.AddGraphQLServer()
             .AddQueryType<Query>()
             .AddType<EmployeeType>()
             .AddType<CustomerType>()
             .AddProjections()
             .AddFiltering();            
        }        
    }
}