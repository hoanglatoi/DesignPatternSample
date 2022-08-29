using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Structutal
{
    public interface IVideo
    {
        void display();
    }

    public class RealVideo : IVideo
    {

        private string _fileName;

        public RealVideo(string fileName)
        {
            _fileName = fileName;
            loadFromDisk(_fileName);
        }

        public void display()
        {
            Console.WriteLine("Displaying " + _fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading " + fileName);
        }
    }

    public class ProxyVideo : IVideo
    {
        private RealVideo realVideo;
        private string fileName;

        public ProxyVideo(string fileName)
        {
            this.fileName = fileName;
        }
        public void display()
        {
            if (realVideo == null) // lazy loading
            {
                realVideo = new RealVideo(fileName);
            }
            realVideo.display();
        }
    }

}
