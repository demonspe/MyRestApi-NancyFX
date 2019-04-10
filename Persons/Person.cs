using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public int Age { get =>
                (DateTime.Now.DayOfYear >= BirthDay.DayOfYear) ?
                (DateTime.Now.Year - BirthDay.Year) :
                (DateTime.Now.Year - BirthDay.Year - 1);
        }

        /// <summary> Create instance </summary>
        /// <param name="name">Name of person</param>
        /// <param name="birthDay">Birthday date</param>
        /// <returns></returns>
        public static Person Create(string name, DateTime birthDay)
        {
            var p = new Person() { Id = Guid.NewGuid(), Name = name, BirthDay = birthDay };
            return p.Age < 120 ? p : null; 
        }
    }
}
