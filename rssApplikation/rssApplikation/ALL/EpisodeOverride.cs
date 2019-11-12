using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    public class EpisodeOverride
    {
        private string episodeName { get; set; }
        private string podcastName { get; set; }
        private string episodeDetail { get; set; }

        public EpisodeOverride(string episodeName, string podcastName, string episodeDetail)
        {
            this.episodeName = episodeName;
            this.podcastName = podcastName;
            this.episodeDetail = episodeDetail;

        }

        public EpisodeOverride()
        {

        }

        public virtual string overrideEpisodeDetail()
        {
            return "This will be overwritten";
        }
    }
}
