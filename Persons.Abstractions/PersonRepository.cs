using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Abstractions
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbConnection db;
        public PersonRepository(IDbConnection db)
        {
            this.db = db;
        }

        public Person Find(Guid id)
        {
            return db.Query<Person>("SELECT * FROM Persons WHERE Id = @id", new { id }).FirstOrDefault(); ;
        }

        public void Insert(Person item)
        {
            db.Query<Guid>("INSERT INTO Users (Id, Name, BirthDay) VALUES(@Id, @Name, @Age);", item);
        }
    }
}
