using Persons.Data;
using System;

namespace Persons.Commands
{
    class CreatePersonHandler : ICommandHandler<CreatePerson>
    {
        //IRepository
        private readonly IPersonRepository _personRepos;

        public CreatePersonHandler(IPersonRepository repository)
        {
            _personRepos = repository;
        }

        public void Handle(CreatePerson command)
        {
            var person = new Person() {
                Id = command.PersonId,
                Name = command.Name,
                BirthDay = command.BirthDay
            };
            //Db insert
            _personRepos.Insert(person);
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
