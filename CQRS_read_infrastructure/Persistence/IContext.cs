using CQRS_read_infrastructure.Persistence.People;

namespace CQRS_read_infrastructure.Persistence
{
    public interface IContext
    {
        IPersonRepository people { get; set; }
    }
}
