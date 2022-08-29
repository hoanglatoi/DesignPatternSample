using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral
{
    public class ExportContext
    {
        private IExport Export;

        public ExportContext(IExport Export)
        {
            this.Export = Export;
        }
        public void SetStrategy(IExport Export)
        {
            this.Export = Export;
        }
        public void CreateArchive(string fileName)
        {
            Export.ExportFile(fileName);
        }
    }

    public interface IExport
    {
        void ExportFile(string fileName);
    }

    public class ExportJPG : IExport
    {
        public void ExportFile(string fileName)
        {
            Console.WriteLine("Export file: '" + fileName
                 + ".JPG' successfully");
        }
    }

    public class ExportPDF : IExport
    {
        public void ExportFile(string fileName)
        {
            Console.WriteLine("Export file: '" + fileName
                 + ".PDF' successfully");
        }
    }

    public class ExportPNG : IExport
    {
        public void ExportFile(string fileName)
        {
            Console.WriteLine("Export file: '" + fileName
                 + ".PNG' successfully");
        }
    }



}
