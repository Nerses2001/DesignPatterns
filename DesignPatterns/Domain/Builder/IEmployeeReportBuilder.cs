using DesignPatterns.Builder;

namespace DesignPatterns.Domain.Builder;

public interface IEmployeeReportBuilder
{
    public IEmployeeReportBuilder BuildHeader();
    public IEmployeeReportBuilder BuildBody();
    public IEmployeeReportBuilder BuildFooter();
    public EmployeeReport GetReport();
}