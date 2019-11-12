using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using rssApplikation.DL;
namespace rssApplikation.ALL
{
    class ALLHandler
    {
        public static void CreateALL()
        {
            DLHandler.CreatePodcasts();
            DLHandler.CreateEpisodes();
            DLHandler.CreateCategories();
        }

        public static void SaveALL()
        {
            DLHandler.SavePodcasts();
            DLHandler.SaveEpisodes();
            DLHandler.SaveCategories();
        }
    }
}
