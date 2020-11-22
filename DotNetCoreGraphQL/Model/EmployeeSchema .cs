using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreGraphQL.Model
{
    public class EmployeeSchema : Schema
    {
        public EmployeeSchema(IDependencyResolver resolver)
        {
            Query = resolver.Resolve<EmployeeQuery>();
            DependencyResolver = resolver;
        }

    }
}
