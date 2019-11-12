using rssApplikation.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace rssApplikation.ALL
{
    class PodcastUpdate
    {
        public static event EventHandler PodcastUpdateFrequency;

        public static void pUpdate(string podcastName, string category, int frequency, string url)
        {
            new Timer().Elapsed += (sender, e) => AsyncEvent(sender, e, podcastName, category, frequency, url);
            new Timer().Interval = frequency * 1000;
            new Timer().Enabled = true;
        }

        private static async void AsyncEvent(object source, ElapsedEventArgs e, string podcastName, string category, int frequency, string url)
        {
            bool exists = false;
            foreach (var pod in PodcastList.GetPodcasts().Where(p => p.PodcastName.Equals(podcastName)))
            {
                exists = true;
            }
            if (exists)
            {
                int episodecount = 0;
                string podcastname = "";
                int pfrequency = 0;
                int i = 0;
                
                foreach (var podcast in PodcastList.GetPodcasts().Where(p => p.PodcastName.Equals(podcastName)))
                {
                    podcastname = podcast.PodcastName;
                    episodecount = podcast.EpisodeCount;
                    pfrequency = podcast.PodcastUpdateFrequency;
                    i++;
                }

                if (await DLHandler.GetEpisodeCount(url) != episodecount)
                {
                    PodcastList.RemovePodcast(podcastname);
                    EpisodeList.RemoveEpisode(podcastname);
                    Podcast.AddPodcast(url, frequency, category);
                    PodcastUpdateFrequency(source, e);
                }
            }
        }
    }
}
