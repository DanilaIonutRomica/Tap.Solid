using Tap.Solid.Dip.ReportExporters;

namespace Tap.Solid.Dip.Services
{
    public class ReportService : IReportService
    {
        private readonly IStudentRepository studentRepository;
        private readonly IPdfReportExporter pdfReportExporter;
        public ReportService(IStudentRepository studentRepository, IPdfReportExporter pdfReportExporter)
        {
            this.studentRepository = studentRepository;
            this.pdfReportExporter = pdfReportExporter;

        }
        public void GenerateReport()
        {
            
            var students = studentRepository.GetAll();
            pdfReportExporter.Export(students);
        }
    }
}
