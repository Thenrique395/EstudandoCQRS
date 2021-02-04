using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CQRS_read_infrastructure.Persistence.People
{
    public class PersonRepository : IPersonRepository
    {
        private static List<Person> ListPersonMemory = new List<Person>();

        public void Delete(Person entity)
        {
            ListPersonMemory.Remove(entity);
        }

        public void Delete(object id)
        {
            ListPersonMemory.Remove(this.Find(id));
        }

        public Person Find(object id)
        {
            return ListPersonMemory.AsQueryable().FirstOrDefault(p => p.Id.Equals(id));
        }

        public IQueryable<Person> Get(Expression<Func<Person, bool>> predicate = null)
        {
            return predicate != null ? ListPersonMemory.AsQueryable().Where(predicate) : ListPersonMemory.AsQueryable();
        }

        public void Insert(Person entity)
        {
            if (entity.Id == -1)
            {
                entity = new Person(
                    ListPersonMemory.Count + 1, entity.Class, entity.Nome, entity.Idade);
                ListPersonMemory.Add(entity);
            }
        }

        public void Update(Person entity)
        {
            var person = this.Find(entity.Id);
            person.Class = entity.Class;
            person.Idade = entity.Idade;
            person.Nome = entity.Nome;
        }
    }
}
