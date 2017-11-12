using System.IO;
using MediaToolkit;
using VideoLibrary;
using MediaToolkit.Model;

namespace TagTunes
{
    public class DownloadJob
    {
        public TagDownload TagDownload;

        public DownloadJob(TagDownload tagDownload)
        {
            this.TagDownload = tagDownload;
        }

        public void Execute()
        {
            string libraryPath = Properties.Settings.Default.LibraryLocation;

            string fileName = Path.Combine(libraryPath, TagDownload.TagFile.ToString());

            YouTube youtube = YouTube.Default;
            Video video = youtube.GetVideo(this.TagDownload.YoutubeUri);

            System.IO.File.WriteAllBytes(fileName + ".vid", video.GetBytes());

            var inputFile = new MediaFile { Filename = fileName + ".vid" };
            var outputFile = new MediaFile { Filename = $"{fileName}.mp3" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }

            File.Delete(inputFile.Filename);

            // Write dem meta shiz
            TagLib.File tagLibFile = TagLib.File.Create(outputFile.Filename);

            tagLibFile.Tag.Title = TagDownload.TagMeta.Name;
            tagLibFile.Tag.Album = TagDownload.TagMeta.Album;
            tagLibFile.Tag.Artists = new string[] { TagDownload.TagMeta.Artist };

            tagLibFile.Save();

            Context.MainForm.DoRefresh();
        }
    }
}
