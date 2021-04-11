using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoDownloader videoDownloader = new VideoDownloader();
            string file = videoDownloader.Download(2, Enums.VideoService.Vimeo, Enums.FileType.MPEG4);
            Console.WriteLine(file);
            Console.ReadKey();
        }
    }
}
