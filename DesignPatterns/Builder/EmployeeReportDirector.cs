using DesignPatterns.Domain.Builder;

namespace DesignPatterns.Builder;

public class EmployeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmployeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        // _builder.BuildBody();
        // _builder.BuildFooter();
        // _builder.BuildHeader();
        _builder
            .BuildHeader()
            .BuildBody()
            .BuildFooter();
    }
}