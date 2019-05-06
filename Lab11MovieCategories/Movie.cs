using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11MovieCategories
{
    class Movie
    {
        private string titles;
        private string categories;

        public string Title
        {
            set { titles = value; }
            get { return titles; }
        }

        public string Categories
        {
            set { categories = value; }
            get { return categories; }
        }
        public Movie(string _titles, string _categories)
        {
            titles = _titles;
            categories = _categories;
        }

        public virtual string Movies()
        {
            return "movies";
        }
         
        
    }
}
