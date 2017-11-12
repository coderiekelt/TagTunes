using System.Threading;

namespace TagTunes
{
    public static class Context
    {
        public static FormMain MainForm;

        public static void QueueDownload(TagDownload tagDownload)
        {
            DownloadJob downloadJob = new DownloadJob(tagDownload);

            Thread downloadThread = new Thread(downloadJob.Execute);
            downloadThread.Start();
        }
    }
}
