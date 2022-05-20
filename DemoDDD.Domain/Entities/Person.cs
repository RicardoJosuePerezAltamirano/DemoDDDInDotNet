using DemoDDD.Domain.ValueObjects;

namespace DemoDDD.Domain.Entities
{
    public class Person
    {
        public Guid Id { get; init; }
        public PersonName Name  { get; private set; }
        public Person(Guid id)
        {
            this.Id = id;
        }
        public void SetName(PersonName name)
        {
            Name = name;
        }
        /*
         * metodos con logica de negocios 
         * */

    }
}
