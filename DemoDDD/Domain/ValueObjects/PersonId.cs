namespace DemoDDD.Domain.ValueObjects
{
    public record PersonId
    {
        public Guid value { get; init; }
        internal PersonId(Guid value_)
        {
            value = value_;

        }
        public static PersonId create(Guid value)
        {
            return new PersonId(value);
        }

        public static implicit operator Guid(PersonId personId)
        {
            return personId.value;
        }
    }
}
