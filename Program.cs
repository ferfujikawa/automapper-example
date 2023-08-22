using AutoMapper;
using automapper_example.Entities;
using automapper_example.Entities.Profiles;
using automapper_example.ValueObjects;
using automapper_example.ViewModels;

var config = new MapperConfiguration(cfg => {
    cfg.CreateMap<Employee, EmployeeViewModel>();
    cfg.AddProfile<EmployeeProfile>();
});
var mapper = new Mapper(config);

var department = new Department("Finance");

var employee = new Employee(new Name("Fernando", "Fujikawa"), department);
var employeeViewModel = mapper.Map<EmployeeViewModel>(employee);

Console.WriteLine($"Id: {employeeViewModel.Id}\n" +
    $"FirstName: {employeeViewModel.FirstName}\n" +
    $"LastName: {employeeViewModel.LastName}\n" +
    $"DepartmentName: {employeeViewModel.DepartmentName}");