using automapper_example.ValueObjects;

namespace automapper_example.Entities
{
    public class Employee
    {
        public Guid Id { get; private set; }
        public Name Name { get; private set; }
        public Department Department { get; private set; }

        public Employee(Name name, Department department)
        {
            Id = Guid.NewGuid();
            Name = name;
            Department = department;
        }
    }
}
