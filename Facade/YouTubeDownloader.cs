using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade
{
    public class YouTubeDownloader
    {
        List<ServiceVideo> ServiceVideos = new List<ServiceVideo>()
        {
            new ServiceVideo() { Id = 1, Title = "Harry Portier", URL = "https://www.youtube.com/watch?v=Htaj3o3JD8I", File = "Harry Portier file from YouTube"},
            new ServiceVideo() { Id = 2, Title = "Denver kumpel sprzed 6 tys. lat", URL = "https://vimeo.com/84114639", File = "Denver kumpel sprzed 6 tys. lat file from YouTube"}
        };

        public string Download(string url)
        {
            return ServiceVideos.Where(q => String.Equals(url, q.URL))?.FirstOrDefault()?.File ?? null;
        }
    }
}
