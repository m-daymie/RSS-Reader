using rssApplikation.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{

    public class Podcast : IPodcastName
    {
        private string podcastName { get; set; }
        private string podcastCategory { get; set; }
        private int podcastUpdateFrequency { get; set; }
        private int episodeCount { get; set; }
        private string url { get; set; }

        //Wrappar fälten i en public så att den kan nås
        public string PodcastName
        {
            get => podcastName;
            set => podcastName = value;
        }

        public string PodcastCategory
        {
            get => podcastCategory;
            set => podcastCategory = value;
        }

        public int PodcastUpdateFrequency
        {
            get => podcastUpdateFrequency;
            set => podcastUpdateFrequency = value;
        }

        public int EpisodeCount
        {
            get => episodeCount;
            set => episodeCount = value;
        }

        public string Url
        {
            get => url;
            set => url = value;
        }
        //Wrappar fälten i en public så att den kan refereras utanför klasses

        public Podcast(string podcastName, string podcastCategory, int podcastUpdateFrequency, int episodeCount, string url)
        {
            this.podcastName = podcastName;
            this.podcastCategory = podcastCategory;
            this.podcastUpdateFrequency = podcastUpdateFrequency;
            this.episodeCount = episodeCount;
            this.url = url;
        }

        public Podcast()
        {

        }
        public static void AddPodcast(string category, int updFrequency, string url)
        {
                DLHandler.GetPodcastFromRss(category, updFrequency, url);
        }


    }
}
