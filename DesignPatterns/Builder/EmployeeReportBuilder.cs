using DesignPatterns.Domain.Builder;

namespace DesignPatterns.Builder;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;
    private readonly IEnumerable<Employee> _employees;

    public EmployeeReportBuilder(IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }
    public IEmployeeReportBuilder BuildHeader()
    {

        _employeeReport.Header = $"Employees report on data: {DateTime.Now}\n";
        _employeeReport.Header += "\n ________________________________________\n";
        return this;
    }

    public IEmployeeReportBuilder BuildBody()
    {
        _employeeReport.Bondy = string.Join(Environment.NewLine, _employees.Select(e => $"Employ: {e.Name}\t\tSalary: {e.Salary} $"));
        return this;
    }

    public IEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = "\n ___________________________________________\n";
        _employeeReport.Footer += $"\n Total employees: {_employees.Count()}" + $"Total  Salary: {_employees.Sum(e => e.Salary)}";
        return this;
    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;
        _employeeReport = new EmployeeReport();
        return employeeReport;
    }
}