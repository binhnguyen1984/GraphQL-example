using HotChocolate.Types;
using northwinddb.Models;

namespace GraphQlApi.Types
{
    public class CustomerType : ObjectType<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(x => x.Address);
            descriptor.Field(x => x.City);
            descriptor.Field(x => x.CompanyName);
            descriptor.Field(x => x.ContactName);
            descriptor.Field(x => x.ContactTitle);
            descriptor.Field(x => x.Country);
        }
    }
}