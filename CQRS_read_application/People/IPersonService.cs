using CQRS_read_infrastructure.Persistence.People;
using System.Linq;

namespace CQRS_read_application.People
{
    public interface IPersonService : IApplicationService<Person>
    {
        Person Find(int id);
        IQueryable<Person> GetByName(string nome);
        IQueryable<Person> GetAll(string nome);
        void Insert(Person person);
        void Update(Person person);
        void Delete(int id);



    }
}
