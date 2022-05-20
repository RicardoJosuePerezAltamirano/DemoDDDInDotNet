using DemoDDD.Commands;
using DemoDDD.Domain.Entities;
using DemoDDD.Domain.Repositories;
using DemoDDD.Domain.ValueObjects;
using DemoDDD.Queries;

namespace DemoDDD.ApplicationServices
{
    public class DemoServices
    {
        private readonly IPersonRepository personRepository;
        private readonly PersonQueries queries;

        public DemoServices(IPersonRepository personRepository
            , PersonQueries queries)
        {
            this.personRepository = personRepository;
            this.queries = queries;
        }
        public async Task HandleCommandAsync(CreatePersonCommand command)
        {
            var person = new Person(PersonId.create(command.id));
            person.SetName(PersonName.Create(command.Name));
            await personRepository.AddPersonAsync(person);
        }

        public async Task<Person> GetPersonAsync(Guid id)
        {
            return await queries.GetPersonbyIdAsync(id);
        }
    }
}
