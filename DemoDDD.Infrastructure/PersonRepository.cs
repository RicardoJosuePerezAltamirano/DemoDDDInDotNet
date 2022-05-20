using DemoDDD.Domain.Entities;
using DemoDDD.Domain.Repositories;
using DemoDDD.Domain.ValueObjects;

namespace DemoDDD.Infrastructure
{
    public class PersonRepository : IPersonRepository
    {
        DemoDatabasesContext context;
        public PersonRepository(DemoDatabasesContext context_)
        {
            context = context_;
        }
        public async Task AddPersonAsync(Person person)
        {
            await context.AddAsync(person);
            await context.SaveChangesAsync();
        }

        public async Task<Person> GetPersonByIdAsync(PersonId Id)
        {
            return await context.Persons.FindAsync((Guid)Id);
            
        }
    }
}
