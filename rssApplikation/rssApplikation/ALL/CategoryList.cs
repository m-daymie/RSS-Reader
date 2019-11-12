using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    class CategoryList
    {
        private static List<Category> categories { get; set; }

        public CategoryList()
        {
            categories = new List<Category>();
        }

        public static void Add(Category category)
        {
            categories.Add(category);
        }

        public static List<Category> GetCategories()
        {
            return categories;
        }
    }
}
