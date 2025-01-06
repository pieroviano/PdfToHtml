using PdfRepresentation.Model.Pdf;

namespace PdfRepresentation
{
    public interface IPdfWriter
    {
        string ConvertPdf(PdfDetails pdf);

        string ConvertPage(PageDetails page);

    }
}