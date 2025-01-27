﻿using PdfRepresentation.Html;
using PdfRepresentation.Model.Config;

namespace PdfRepresentation.Helpers
{
    internal class CreateHelper
    {
        public static PdfImageHtmlWriter CreateImageWriter(HtmlWriterConfig config)
        {
            return new PdfImageHtmlWriter(config.EmbeddedImages, config.DirImages);
        }

        public static PdfShapeHtmlWriter CreateShapeWriter(HtmlWriterConfig config)
        {
            if (config.UseCanvas)
            {
                return new PdfShapeCanvasHtmlWriter();
            }

            return new PdfShapeSvgHtmlWriter();
        }

        public static PdfTextHtmlWriter CreateTextWriter()
        {
            return new PdfTextHtmlWriter();
        }
    }
}
