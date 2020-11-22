using DotNetCoreRepository.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreGraphQL.Model
{
    public class EmployeeQuery : ObjectGraphType<object>
    {
        public EmployeeQuery(IEmployeeRepository repository)
        {
            Name = "EmployeeQuery";

            Field<EmployeeInfoType>(
               "employee",
               arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "Id" }),
               resolve: context => repository.GetEmployee(context.GetArgument<int>("id"))
            );

            Field<ListGraphType<EmployeeInfoType>>(
             "employees",
             resolve: context => repository.GetAllEmployee()
          );
        }
    }
}
