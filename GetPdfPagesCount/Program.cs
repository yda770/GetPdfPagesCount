using iText.Kernel.Pdf;
using System;
using System.IO;

namespace GetPdfPagesCount
{
    class Program
    {
        static int Main(string[] args)
        {
            if(args.Length < 2)
            {
                return -1;
            }

            
            var doc = new PdfDocument(new PdfReader(args[0].Trim()));
            Type type = doc.GetType();

            string[] lines =
            {            
                doc.GetNumberOfPages().ToString()             
            };

            File.WriteAllLinesAsync(args[1].Trim(), lines);

            doc.Close();
            return 0;

        }
    }
}
