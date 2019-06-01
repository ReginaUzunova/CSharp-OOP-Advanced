using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtendedDatabase
{
    public class Database
    {
        private const int Capacity = 16;
        private IPerson[] people;
        private int index;

        public Database(params IPerson[] peopleInput)
        {
            this.people = new IPerson[Capacity];
            this.index = -1;
            this.SetInitialElements(peopleInput);
        }

        public int Index => this.index;

        private void SetInitialElements(params IPerson[] peopleInput)
        {
            if (peopleInput.Length > Capacity)
            {
                throw new InvalidOperationException("Invalid Capacity!");
            }

            foreach (var person in peopleInput)
            {
                this.Add(person);
            }
        }

        public void Add(IPerson person)
        {
            if (this.index >= Capacity - 1)
            {
                throw new InvalidOperationException("The array is full!");
            }

            if (this.people.Any(p => p != null && p.Username == person.Username))
            {
                throw new InvalidOperationException("User with that name already exist!");
            }

            if (this.people.Any(p => p != null && p.Id == person.Id))
            {
                throw new InvalidOperationException("User with that Id already exist!");
            }

            this.people[++this.index] = person;
        }

        public void Remove()
        {
            if (this.index == -1)
            {
                throw new InvalidOperationException("The array is empty!");
            }

            this.people[this.index] = null;
            this.index--;
        }

        public IPerson[] Fetch()
        {
            return this.people.Take(this.index + 1).ToArray();
        }

        public IPerson FindByUsername(string username)
        {
            if (username == null)
            {
                throw new ArgumentNullException("Invalid parameter type!");
            }

            if (!this.people.Any(p => p != null && p.Username == username))
            {
                throw new InvalidOperationException("There isn't person with that username!");
            }

            return this.people.First(p => p.Username == username);
        }

        public IPerson FindById(long id)
        {
            if (id < 0)
            {
                throw new ArgumentOutOfRangeException("Id must be positive number!");
            }

            if (!this.people.Any(p => p != null && p.Id == id))
            {
                throw new InvalidOperationException("There isn't person with that Id!");
            }

            return this.people.First(p => p.Id == id);
        }
    }
}
