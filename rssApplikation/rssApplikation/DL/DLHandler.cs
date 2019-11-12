using rssApplikation.ALL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace rssApplikation.DL
{
    class DLHandler
    {
        public static void CreatePodcasts()
        {
            if (File.Exists("podcasts.txt"))
            {
                XDocument.Load("podcasts.txt").Descendants("Podcast").Select(p => (
                    podcastName: p.Element("PodcastName").Value,
                    podcastCategory: p.Element("PodcastCategory").Value,
                    podcastUpdateFrequency: Convert.ToInt32(p.Element("PodcastUpdateFrequency").Value),
                    episodeCount: Convert.ToInt32(p.Element("EpisodeCount").Value),
                    url: p.Element("Url").Value
                )).ToList().ForEach(p =>
                {
                    var podcast = new Podcast(p.podcastName, p.podcastCategory, p.podcastUpdateFrequency, p.episodeCount, p.url);
                    Podcast.AddPodcast(p.podcastCategory, p.podcastUpdateFrequency, p.url);
                    PodcastUpdate.pUpdate(p.podcastName, p.podcastCategory, p.podcastUpdateFrequency, p.url);
                });
            }
        }
        public static void SavePodcasts()
        {
            if (File.Exists("podcasts.txt"))
            {
                File.Delete("podcasts.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\podcasts.txt"))
            {
                new XmlSerializer(typeof(List<Podcast>)).Serialize(stream, PodcastList.GetPodcasts());
                stream.Close();
            }
        }

        public static void CreateEpisodes()
        {
            if (File.Exists("episode.txt"))
            {
                XDocument.Load("episode.txt").Descendants("Episode").Select(p => new
                {
                    episodeName = p.Element("EpisodeName").Value,
                    podcastName = p.Element("PodcastName").Value,
                    episodeDetail = p.Element("EpisodeDetail").Value,

                }).ToList().ForEach(p =>
                {
                    EpisodeList.Add(new Episode(p.episodeName, p.podcastName, p.episodeDetail));
                });
            }
        }

        public static void SaveEpisodes()
        {
            if (File.Exists("episode.txt"))
            {
                File.Delete("episode.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\episode.txt"))
            {
                new XmlSerializer(typeof(List<Episode>)).Serialize(stream, EpisodeList.GetEpisodes());
                stream.Close();
            }
        }

        public static async Task<int> GetEpisodeCount(string url)
        {
            using (var reader = XmlReader.Create(url))
            {
                int episodecount = 0;
                var feed = SyndicationFeed.Load(reader);
                foreach (SyndicationItem item in feed.Items)
                {
                    episodecount++;
                }
                return episodecount;
            }
        }

        public static void GetPodcastFromRss(string category, int updateFrequency, string url)
        {
            using (var reader = XmlReader.Create(url))
            {
                try
                {
                    var feed = SyndicationFeed.Load(reader);
                    var podcastName = feed.Title.Text;
                    int episodeCount = 0;
                    foreach (SyndicationItem s in feed.Items)
                    {
                        var episodeName = s.Title.Text;
                        var detail = s.Summary.Text;
                        var episode = new Episode(episodeName, podcastName, detail);
                        EpisodeList.Add(episode);
                        episodeCount++;
                    }

                    PodcastList.AddPodcast(new Podcast(podcastName, category, updateFrequency, episodeCount, url));
                    PodcastUpdate.pUpdate(podcastName, category, updateFrequency, url);
                }
                catch (Exception)
                {
                    System.Windows.Forms.MessageBox.Show("Cannot read RSS");
                }
            }
        }

        public static void CreateCategories()
        {
            if (File.Exists("categories.txt"))
            {
                XDocument.Load("categories.txt").Descendants("Category").Select(p => new
                {
                    categoryName = p.Element("CategoryName").Value,

                }).ToList().ForEach(p =>
                {
                    CategoryList.Add(new Category(p.categoryName));
                });
            }
        }


        public static void SaveCategories()
        {
            if (File.Exists("categories.txt"))
            {
                File.Delete("categories.txt");
            }
            using (Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\categories.txt"))
            {
                new XmlSerializer(typeof(List<Category>)).Serialize(stream, CategoryList.GetCategories());
                stream.Close();
            }
        }
        
    }
}
