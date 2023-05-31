using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PeopleList
    {
        public static readonly List<People> peoples = new List<People>
        {
            new People()
            {
                Id = 1,
                Name = "Mari",
                Age = 31,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 2,
                Name = "Rasmus",
                Age = 21,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("81985602-b844-4bec-9066-7059f7169913")
            },
            new People()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
            new People()
            {
                Id = 5,
                Name = "Anne",
                Age = 19,
                GenderId = Guid.Parse("4c4209e5-7a1b-429d-91ed-bbe20844f29e")
            },
          };
    }
}