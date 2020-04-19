using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class VideoDownloader
    {
        VideoLibrary VideoLibrary = new VideoLibrary();
        YouTubeDownloader YouTubeDownloader = new YouTubeDownloader();
        VimeoDownloader VimeoDownloader = new VimeoDownloader();
        MPEG4Converter MPEG4Converter = new MPEG4Converter();
        OggConverter OggConverter = new OggConverter();
        AudioMixer AudioMixer = new AudioMixer();

        public string Download(long id, Enums.VideoService videoService, Enums.FileType fileType)
        {
            Video video = VideoLibrary.GetVideo(id);

            if (video is null)
            {
                return "Not found";
            }

            string file = null;

            if (videoService == Enums.VideoService.YouTube)
            {
                file = YouTubeDownloader.Download(video.URL);
            }
            else if (videoService == Enums.VideoService.Vimeo)
            {
                file = VimeoDownloader.Download(video.URL);
            }

            if (string.IsNullOrEmpty(file))
            {
                return "Not found";
            }

            if (fileType == Enums.FileType.MPEG4)
            {
                file = MPEG4Converter.Convert(file);
            }
            else if(fileType == Enums.FileType.Ogg)
            {
                file = OggConverter.Convert(file);
            }

            file = AudioMixer.IncreaseAudioQuality(file);

            return file;
        }
    }
}
