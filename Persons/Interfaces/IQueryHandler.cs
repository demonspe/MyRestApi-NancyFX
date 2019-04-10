using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Queries
{
    interface IQueryHandler<in TQuery> where TQuery : IQuery
    {
        void Handle(TQuery query);
    }
}
