using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.Windows.Forms;

namespace rssApplikation.ALL
{
    class Validation
    {
        public static bool VerifyUrl(string url)
        {
            try
            {
                var feed = SyndicationFeed.Load(XmlReader.Create(url));
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("That url did not work, try another!");
                return false;
            }
        }
        public static bool ValidateCategories(string vCategory)
        {
            List<Category> list = CategoryList.GetCategories();
            for (int i = 0; i < list.Count; i++)
            {
                Category category = list[i];
                if (vCategory.Equals(category.CategoryName))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool ValidateTextbox(TextBox textbox)
        {
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                return true;
            }
            MessageBox.Show("Must fill in the textfield!");
            return false;
        }
        public static bool ValidateComboBox(ComboBox combobox)
        {
            if (!string.IsNullOrEmpty(combobox.Text))
            {
                return true;
            }
            MessageBox.Show("Must choose one option!");
            return false;
        }
        public static void ValidateListBox(ListBox listbox)
        {
            if (string.IsNullOrEmpty(listbox.GetItemText(listbox.SelectedItem)))
            {
                MessageBox.Show("You must highlight the specific item before you try to change it!");
            }
        }
        public static bool ValidateUrl(string url)
        {
            foreach (var pod in PodcastList.GetPodcasts().Where(p => p.Url.Equals(url)))
            {
                MessageBox.Show("This podcast already exists");
                return false;
            }
            return true;
        }
    }
}
