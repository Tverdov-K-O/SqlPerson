using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlPerson.Data.Entities
{
    class Person
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string  PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}
