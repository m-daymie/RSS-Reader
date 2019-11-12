using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    public class PodcastList
    {
        private static List<Podcast> podcastList { get; set; }

        public PodcastList()
        {
            podcastList = new List<Podcast>();
        }

        public static void AddPodcast(Podcast podcast)
        {
            podcastList.Add(podcast);
        }

        public static void RemovePodcast(string podcastName)
        {
            podcastList.RemoveAll(p => p.PodcastName.Equals(podcastName));
        }

        public static List<Podcast> GetPodcasts()
        {
            return podcastList;
        }
    }
}
