using DotNetCoreRepository.Model;
using DotNetCoreRepository.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreGraphQL.Model
{
    public class EmployeeInfoType : ObjectGraphType<Employee>
    {
        public EmployeeInfoType(IEmployeeRepository repository)
        {
            Field(x => x.Id).Description("Id");
            Field(x => x.Name).Description("Name");
            Field(x => x.Email).Description("Email");

           // Field<ListGraphType<ParticipantType>>(
           //   "participants",
           //   arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "eventId" }),
           //   resolve: context => repository.GetParticipantInfoByEventId(context.Source.EventId)
           //);
        }
    }
}
