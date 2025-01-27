﻿using System.Threading.Tasks;
using PdfRepresentation.Logic;
using PdfRepresentation.Shared;

namespace PdfRepresentation.Base.Conversion
{
    public abstract class PdfConverter : IPdfConverter
    {
        protected PdfWriterBase writer;

        public string ConvertToText(byte[] pdf)
        {
            var details = PdfDetailsFactory.Create(pdf);
            return details.ToString();
        }

        public Task<string> ConvertToTextAsync(byte[] pdf)
        {
#if NET40 || NET45
            var task = new Task<string>(() => ConvertToText(pdf));
            task.Start();
            return task;
#else
            return Task.FromResult(ConvertToText(pdf));
#endif
        }
    }
}