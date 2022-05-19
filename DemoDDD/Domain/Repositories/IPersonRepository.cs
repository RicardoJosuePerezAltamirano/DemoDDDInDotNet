using DemoDDD.Domain.Entities;
using DemoDDD.Domain.ValueObjects;

namespace DemoDDD.Domain.Repositories
{
    public interface IPersonRepository
    {
        Task<Person> GetPersonByIdAsync(PersonId Id);
        Task AddPersonAsync(Person person);
    }
}
