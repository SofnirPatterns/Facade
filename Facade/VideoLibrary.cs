using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class VideoLibrary
    {
        List<Video> Videos = new List<Video>()
        {
            new Video() { Id = 1, Title = "Harry Portier", URL = "https://www.youtube.com/watch?v=Htaj3o3JD8I" },
            new Video() { Id = 2, Title = "Denver kumpel sprzed 6 tys. lat", URL = "https://vimeo.com/84114639" }
        };

        public Video GetVideo(long id)
        {
            return Videos.Where(q => q.Id == id)?.FirstOrDefault() ?? null;
        }
    }
}
