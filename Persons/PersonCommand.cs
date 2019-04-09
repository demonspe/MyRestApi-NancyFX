using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    class CreatePersonHandler : ICommandHandler<CreatePerson>
    {
        //IRepository

        public CreatePersonHandler()
        {

        }

        public void Handle(CreatePerson command)
        {
            var person = new Person() {
                Id = command.PersonId,
                Name = command.Name,
                BirthDay = command.BirthDay
            };
        }
    }

    class CreatePerson : ICommand
    {
        public Guid PersonId { get; }
        public string Name { get; }
        public DateTime BirthDay { get; }
        public CreatePerson(Guid personId, string name, DateTime birthDay)
        {
            PersonId = personId;
            Name = name;
            BirthDay = birthDay;
        }
        
    }
}
