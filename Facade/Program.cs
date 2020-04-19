using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoDownloader videoDownloader = new VideoDownloader();
            string file = videoDownloader.Download(3, Enums.VideoService.YouTube, Enums.FileType.Ogg);
            Console.WriteLine(file);
            Console.ReadKey();
        }
    }
}
