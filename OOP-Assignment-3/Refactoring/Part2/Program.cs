using Refactoring.Part2.Enrollment;
using Refactoring.Part2.Reports;

namespace Refactoring.Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Reports ===");
            var outDir = Path.Combine(Path.GetTempPath(), "refactoring-lab-part02");
            Directory.CreateDirectory(outDir);

            new CsvReportExporter().Export(Path.Combine(outDir, "report.csv"));
            new JsonReportExporter().Export(Path.Combine(outDir, "report.json"));
            new TextReportExporter().Export(Path.Combine(outDir, "report.txt"));
            Console.WriteLine($"Wrote reports to {outDir}");
            Console.WriteLine();

            Console.WriteLine("=== Enrollment ===");

            var studentId = "S100";
            var courseId = "CS201";
            var amount = 1500m;

            var enrollment = new EnrollmentFacade(
                new PaymentGateway(),
                new SeatInventory(),
                new InvoiceGenerator(),
                new EmailService());

            enrollment.Enroll(studentId, courseId, amount);
        }
    }
}
