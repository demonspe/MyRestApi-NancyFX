using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Queries
{
    public class GetPersonQueryHandler : IQueryHandler<GetPersonQuery>
    {
        public void Handle(GetPersonQuery query)
        {
            throw new NotImplementedException();
        }
    }

    public class GetPersonQuery: IQuery
    {

    }
}
