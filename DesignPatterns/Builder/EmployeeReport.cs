using System.Text;

namespace DesignPatterns.Builder;

public class EmployeeReport
{
    public string Header { get; set; }
    public string Bondy { get; set; }
    public string Footer { get; set; }


    public override string ToString()
    {
        return new StringBuilder().Append(Header).Append(Bondy).Append(Footer).ToString();
    }
}