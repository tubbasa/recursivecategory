using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCategories
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentCategoryId { get; set; }
    }
    public class CategoryTree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryTree> SubCategories { get; set; }
    }
}
