using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structutal
{
    public interface IFileComponent
    {
        public void ShowProperty();
        public long Totalsize();
    } 

    public class FileLeaf: IFileComponent
    {
        private string name;
        private long size;

        public FileLeaf(string name, long size)
        {
            this.name = name;
            this.size = size;
        }

        public long Totalsize()
        {
            return size;
        }

        public void ShowProperty()
        {
            Console.WriteLine("FileLeaf [name=" + name + ", size=" + size + "]");
        }
    }

    public class FolderComposite : IFileComponent
    {
        private List<IFileComponent> files = new List<IFileComponent>();

        public FolderComposite(List<IFileComponent> files)
        {
            this.files = files;
        }

        public long Totalsize()
        {
            long totalsize = 0;
            foreach (IFileComponent file in files)
            {
                totalsize = totalsize + file.Totalsize();
            }
            return totalsize;
        }

        public void ShowProperty()
        {
            foreach(IFileComponent file in files)
            {
                file.ShowProperty();
            }
        }
    }
}
