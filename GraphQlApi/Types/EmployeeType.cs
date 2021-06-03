using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate.Types;
using northwinddb.Models;

namespace GraphQlApi.Types
{
    public class EmployeeType : ObjectType<Employee>
    {
        protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
        {
            descriptor.Field(x => x.Address);
            descriptor.Field(x => x.City);
            descriptor.Field(x => x.BirthDate);
            descriptor.Field(x => x.EmployeeId);
            descriptor.Field(x => x.FirstName);
            descriptor.Field(x => x.Country);
        }
    }
}
