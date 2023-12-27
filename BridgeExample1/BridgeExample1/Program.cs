internal class Program
{
    private static void Main(string[] args)
    {

        Report report = new EmployeePerformnceReport(new DesktopFormat());
        report.display();

        Console.WriteLine("*************");

        Report report1 = new SalesReport(new WebFormat());
        report1.display();

    }
}

class Report
{
    private IReportFormat format;

    public Report(IReportFormat format)
    {
        this.format = format;
    }

    public virtual void display()
    {
        format.Generate();
    }
}

interface IReportFormat
{
    public void Generate();
}

class DesktopFormat() : IReportFormat
{
    public void Generate()
    {
        Console.WriteLine("rapor desktop formatında oluşturuldu");
    }
}

class WebFormat : IReportFormat
{
    public void Generate()
    {
        Console.WriteLine("rapor web formatında oluşturuldu");
    }
}

class SalesReport : Report
{
    public SalesReport(IReportFormat format) : base(format)//constructorın mirası
    {
    }

    public override void display()
    {
        base.display();
        Console.WriteLine("Satış raporu...");
    }

}

class EmployeePerformnceReport : Report
{
    public EmployeePerformnceReport(IReportFormat format) : base(format)
    {
    }

    public override void display()
    {
        base.display();
        Console.WriteLine("employee performance raporu...");
    }
}
