using PdfRepresentation.Model.Pdf;

namespace PdfRepresentation
{
    public interface IPdfWriterEx: IPdfWriter
    {
        string ConvertPdf(PdfDetails pdf, bool shouldSerializeAll);

        string ConvertPage(PageDetails page, bool shouldSerializeAll);

    }
}