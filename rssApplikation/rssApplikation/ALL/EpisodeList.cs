using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    class EpisodeList
    {
         private static List<Episode> episodeList { get; set; }


         public EpisodeList()
         {
             episodeList = new List<Episode>();
         }


         public static void Add(Episode e)
         {
             episodeList.Add(e);
         }

         public static void RemoveEpisode(string episodeName)
         {
             episodeList.RemoveAll(episode => episode.PodcastName.Equals(episodeName));
         }

         public static List<Episode> GetEpisodes()
         {
             return episodeList;
         }
    }
}
