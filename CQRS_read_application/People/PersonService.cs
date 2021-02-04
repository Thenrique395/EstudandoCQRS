using CQRS_read_infrastructure.Persistence.People;
using System.Linq;

namespace CQRS_read_application.People
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _personRepository;
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public Person Find(int id)
        {
            return _personRepository.Find(id);
        }

        public IQueryable<Person> GetAll(string nome)
        {
            return _personRepository.Get();
        }

        public IQueryable<Person> GetByName(string nome)
        {
            return _personRepository.Get(p => p.Nome.ToUpper().Contains(nome.ToUpper())); ;
        }

        public void Insert(Person person)
        {
            _personRepository.Insert(person);
        }

        public void Update(Person person)
        {
            _personRepository.Update(person);
        }
    }
}
