namespace Core.Entities.Concrete
{
    public class PostalCode : IEntity
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
    }
}
