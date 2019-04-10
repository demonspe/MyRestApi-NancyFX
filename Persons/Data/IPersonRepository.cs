using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Data
{
    interface IPersonRepository
    {
        Person Find(Guid id);

        void Insert(Person item);
    }
}
