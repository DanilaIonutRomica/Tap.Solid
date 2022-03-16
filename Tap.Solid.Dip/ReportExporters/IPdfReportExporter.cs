using Tap.Solid.Dip.Entities;

namespace Tap.Solid.Dip.ReportExporters
{
    public interface IPdfReportExporter
    {
        public void Export(List<Student> students);
    }
}