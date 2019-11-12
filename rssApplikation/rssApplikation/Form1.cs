using rssApplikation.ALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rssApplikation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            autoResizeColumns(listViewPodcast);
            CreatePECList();
            ALLHandler.CreateALL();
            UpdatelistViewPodcast();
            UpdatelistBoxCategory();
            UpdatecomboBoxCategory();
            PodcastUpdate.PodcastUpdateFrequency += new EventHandler(eventhandler);
        }

        public static void autoResizeColumns(ListView lv)
        {
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            ListView.ColumnHeaderCollection cc = lv.Columns;
            for (int i = 0; i < cc.Count; i++)
            {
                int colWidth = TextRenderer.MeasureText(cc[i].Text, lv.Font).Width + 10;
                if (colWidth > cc[i].Width)
                {
                    cc[i].Width = colWidth;
                }
            }
        }

        private static void CreatePECList()
        {
            new PodcastList();
            new EpisodeList();
            new CategoryList();
        }

        void eventhandler(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdatelistViewPodcast()));
            }
            else
            {
                UpdatelistViewPodcast();
            }

        }

        public void UpdatelistViewPodcast()
        {
            listViewPodcast.Items.Clear();
            List<Podcast> podcastlist = PodcastList.GetPodcasts();
            for (int i = 0; i < podcastlist.Count; i++)
            {
                Podcast pod = podcastlist[i];
                var list = new ListViewItem(new[]
                {
                    pod.PodcastName,
                    pod.PodcastCategory,
                    pod.EpisodeCount.ToString(),
                    pod.PodcastUpdateFrequency.ToString() + " sekunder"
                });
                listViewPodcast.Items.Add(list);
            }
        }

        public void UpdatelistViewPodcastCategory(string category)
        {
            listViewPodcast.Items.Clear();
            foreach (var pod in PodcastList.GetPodcasts().Where(p => p.PodcastCategory == category))
            {
                var list = new ListViewItem(new[]
                {
                    pod.PodcastName,
                    pod.PodcastCategory,
                    pod.EpisodeCount.ToString(),
                    pod.PodcastUpdateFrequency.ToString() + " sekunder"
                });
                listViewPodcast.Items.Add(list);
            }
        }

        private void UpdatelistViewEpisodes(string podcast)
        {
            var episodelist = EpisodeList.GetEpisodes().Where(titel => titel.PodcastName == podcast).ToList();
            listViewEpisodes.Items.Clear();
            for (int i = 0; i < episodelist.Count; i++)
            {
                Episode episode = episodelist[i];
                var list = new ListViewItem(new[]
                {
                    episode.EpisodeName
                });
                listViewEpisodes.Items.Add(list);
            }
        }

        private void UpdaterTBoxEpisodeDetail(string episode)
        {
            var episodelist = EpisodeList.GetEpisodes().Where(p => p.EpisodeName.Equals(episode)).ToList();

            foreach (var ep in episodelist)
            {
                rTBoxEpisodeDetail.Text = ep.overrideEpisodeDetail();
            }
        }

        public void UpdatecomboBoxCategory()
        {
            comboBoxCategory.Items.Clear();
            List<Category> list = CategoryList.GetCategories();
            for (int i = 0; i < list.Count; i++)
            {
                Category catetogory = list[i];
                comboBoxCategory.Items.Add(catetogory.CategoryName);
            }
        }

        public void UpdatelistBoxCategory()
        {
            listBoxCategory.Items.Clear();
            List<Category> list = CategoryList.GetCategories();
            for (int i = 0; i < list.Count; i++)
            {
                Category category = list[i];
                listBoxCategory.Items.Add(category.CategoryName);
            }
        }

        public void SaveCategory(string pCategory)
        {
            if (!string.IsNullOrEmpty(listBoxCategory.GetItemText(listBoxCategory.SelectedItem)))
            {
                foreach (var podcategory in CategoryList.GetCategories().Where(c => c.CategoryName.Equals(listBoxCategory.GetItemText(listBoxCategory.SelectedItem))))
                {
                    podcategory.CategoryName = pCategory;
                }
                UpdatecomboBoxCategory();
                UpdatelistBoxCategory();
            }
        }

        private void btnNewPodcast_Click(object sender, EventArgs e)
        {
            if (Validation.ValidateUrl(textBoxUrl.Text) && Validation.ValidateComboBox(comboBoxUpdateFrequency) && Validation.ValidateComboBox(comboBoxCategory))
            {
                int frequency = Convert.ToInt32(comboBoxUpdateFrequency.Text.Split(' ')[0]);
                var category = comboBoxCategory.Text;
                Podcast.AddPodcast(category, frequency, textBoxUrl.Text);
                UpdatelistViewPodcast();
            }

        }

        public void SavePodcast(string podcast)
        {
            foreach (var pod in PodcastList.GetPodcasts().Where(p => p.PodcastName.Equals(podcast)))
            {
                textBoxUrl.Text = pod.Url;
                comboBoxUpdateFrequency.SelectedIndex = comboBoxUpdateFrequency.Items.IndexOf(pod.PodcastUpdateFrequency + " sekunder");
                comboBoxCategory.SelectedIndex = comboBoxCategory.Items.IndexOf(pod.PodcastCategory);
            }
        }

        public void UpdatePodcasts(string podcast)
        {
            int updatefrequency = Convert.ToInt32(comboBoxUpdateFrequency.Text.Split(' ')[0]);
            PodcastList.RemovePodcast(podcast);
            EpisodeList.RemoveEpisode(podcast);
            Podcast.AddPodcast(comboBoxCategory.Text, updatefrequency, textBoxUrl.Text);

            UpdatelistViewPodcast();
            listViewEpisodes.Items.Clear();
            rTBoxEpisodeDetail.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var index = listViewPodcast.SelectedIndices[0];
                string podcast = listViewPodcast.Items[index].SubItems[0].Text;
                UpdatePodcasts(podcast);
            }
            catch (Exception)
            {
                MessageBox.Show("You must select the podcast you want to edit!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string podcast = listViewPodcast.SelectedItems[0].Text;
                PodcastList.RemovePodcast(podcast);
                EpisodeList.RemoveEpisode(podcast);
                UpdatelistViewPodcast();

            }
            catch (Exception)
            {
                MessageBox.Show("You must select the podcast you want to delete!");
            }
        }

        private void listViewPodcast_ItemActivate(object sender, EventArgs e)
        {
            var index = listViewPodcast.SelectedIndices[0];
            string podcastName = listViewPodcast.Items[index].SubItems[0].Text;
            SavePodcast(podcastName);
            UpdatelistViewEpisodes(podcastName);
        }

        private void listViewEpisodes_ItemActivate(object sender, EventArgs e)
        {
            var index = listViewEpisodes.SelectedIndices[0];
            string episode = listViewEpisodes.Items[index].SubItems[0].Text;
            UpdaterTBoxEpisodeDetail(episode);
        }

        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCategory.Text))
            {
                MessageBox.Show("You must fill in the category textfield!");
                return;
            }

            if (Validation.ValidateCategories(textBoxCategory.Text))
            {
                MessageBox.Show("You are trying to add a category that already exists!");
                return;
            }

            Category kategori = new Category(textBoxCategory.Text);
            CategoryList.Add(kategori);
            UpdatecomboBoxCategory();
            UpdatelistBoxCategory();
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            var pCategory = textBoxCategory.Text;
            SaveCategory(pCategory);
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                var category = listBoxCategory.GetItemText(listBoxCategory.SelectedItem);
                int index;
                var categorylist = CategoryList.GetCategories();

                index = categorylist.FindIndex(c => c.CategoryName.Equals(category));
                categorylist.RemoveAt(index);
                UpdatecomboBoxCategory();
                UpdatelistBoxCategory();
            }
            catch (Exception)
            {
                MessageBox.Show("You must select the category you want to delete!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ALLHandler.SaveALL();
        }

        private void listViewPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPodcast.SelectedIndices.Count > 0)
            {
                var index = listViewPodcast.SelectedIndices[0];
                string podcastName = listViewPodcast.Items[index].SubItems[0].Text;
                SavePodcast(podcastName);
                UpdatelistViewEpisodes(podcastName);
            }

        }

        private void listViewEpisodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEpisodes.SelectedIndices.Count > 0)
            {
                var index = listViewEpisodes.SelectedIndices[0];
                string episode = listViewEpisodes.Items[index].SubItems[0].Text;
                UpdaterTBoxEpisodeDetail(episode);
            }
        }
    }
}

