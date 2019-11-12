using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    public class Episode : EpisodeOverride, IPodcastName
    {
        private string episodeName { get; set; }
        private string podcastName { get; set; }
        private string episodeDetail { get; set; }

        public string EpisodeName
        {
            get => episodeName;
            set => episodeName = value;
        }
        public string PodcastName
        {
            get => podcastName;
            set => podcastName = value;
        }

        public string EpisodeDetail
        {
            get => episodeDetail;
            set => episodeDetail = value;
        }

        public Episode(string episodeName, string podcastName, string episodeDetail) : base(episodeName, podcastName, episodeDetail)
        {
            this.episodeName = episodeName;
            this.podcastName = podcastName;
            this.episodeDetail = episodeDetail;

        }

        public Episode()
        {

        }

        public override string overrideEpisodeDetail()
        {
            var newline = "\r\n";
            return "PODCAST: " + PodcastName + newline + "EPISODE: " + EpisodeName + newline + "DETAILS: " + EpisodeDetail;
        }



    }
}
