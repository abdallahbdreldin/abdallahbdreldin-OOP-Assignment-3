namespace Refactoring.Part2.Reports
{
    public class TextReportExporter : ReportExport
    {
        protected override string Format(List<string[]> rows) =>
            string.Join(Environment.NewLine, rows.Select(r => string.Join(" | ", r)));
    }
}
