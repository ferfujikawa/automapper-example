namespace automapper_example.Entities
{
    public class Department
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }

        public Department(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }
    }
}
