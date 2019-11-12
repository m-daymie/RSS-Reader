using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rssApplikation.ALL
{
    public class Category
    {

        private string categoryName { get; set; }

        public string CategoryName
        {
            get { return categoryName;}
            set { categoryName = value; }
        }

        public Category(string categoryName)
        {
            this.categoryName = categoryName;
        }
        public Category()
        {

        }

    }
}
