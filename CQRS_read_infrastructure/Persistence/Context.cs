using CQRS_read_infrastructure.Persistence.People;

namespace CQRS_read_infrastructure.Persistence
{
    public class Context : IContext
    {
        public IPersonRepository people { get; set; }

        public Context(IPersonRepository personRepository)
        {
            this.people =  personRepository;
        }

    }
}
