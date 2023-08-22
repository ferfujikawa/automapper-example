namespace automapper_example.ViewModels
{
    public class EmployeeViewModel
    {
        public Guid Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string DepartmentName { get; private set; }

        public EmployeeViewModel(Guid id, string firstName, string lastName, string departmentName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DepartmentName = departmentName;
        }
    }
}
