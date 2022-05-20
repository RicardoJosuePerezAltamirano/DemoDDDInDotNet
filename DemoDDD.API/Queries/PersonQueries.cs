using DemoDDD.Domain.Entities;
using DemoDDD.Domain.Repositories;

namespace DemoDDD.Queries
{
    public class PersonQueries
    {
        private readonly IPersonRepository personRepository;

        public PersonQueries(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }
        public async Task<Person> GetPersonbyIdAsync(Guid id)
        {
            var response = await personRepository.GetPersonByIdAsync(Domain.ValueObjects.PersonId.create(id));
            return response;
        }
    }
}
