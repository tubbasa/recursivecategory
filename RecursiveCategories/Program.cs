using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveCategories
{
    class Program
    {
        static List<Category> categoryList;
        static List<CategoryTree> categoryTreeList =new List<CategoryTree>();
        static void Main(string[] args)
        {
            categoryList = new List<Category>();
            
            categoryList.Add(new Category { Id = 1, Name = "Category1", ParentCategoryId = 0 });
            categoryList.Add(new Category { Id = 2, Name = "Category2", ParentCategoryId = 0 });
            categoryList.Add(new Category { Id = 3, Name = "Category3", ParentCategoryId = 0 });
            categoryList.Add(new Category { Id = 4, Name = "Category4", ParentCategoryId = 1 });
            categoryList.Add(new Category { Id = 5, Name = "Category5", ParentCategoryId = 1 });
            categoryList.Add(new Category { Id = 6, Name = "Category6", ParentCategoryId = 3 });
            categoryList.Add(new Category { Id = 7, Name = "Category7", ParentCategoryId = 3 });
            categoryList.Add(new Category { Id = 8, Name = "Category8", ParentCategoryId = 3 });
            categoryList.Add(new Category { Id = 9, Name = "Category9", ParentCategoryId = 3 });
            categoryList.Add(new Category { Id = 10, Name = "Category10", ParentCategoryId = 5 });
            categoryList.Add(new Category { Id = 11, Name = "Category11", ParentCategoryId = 5 });
            categoryList.Add(new Category { Id = 12, Name = "Category12", ParentCategoryId = 5 });
            categoryList.Add(new Category { Id = 13, Name = "Category13", ParentCategoryId = 5 });
            categoryList.Add(new Category { Id = 14, Name = "Category14", ParentCategoryId = 2 });
            categoryList.Add(new Category { Id = 15, Name = "Category15", ParentCategoryId = 2 });
            categoryList.Add(new Category { Id = 16, Name = "Category16", ParentCategoryId = 15 });
            categoryList.Add(new Category { Id = 17, Name = "Category17", ParentCategoryId = 13 });

            foreach (var cat in categoryList.Where(c=>c.ParentCategoryId==0))
            {
                categoryTreeList.Add(CategoryTree(cat));
            }
           
            
        }
        public static CategoryTree CategoryTree(Category category)
        {
            var newCategoryTree = new CategoryTree { Id = category.Id, Name = category.Name, SubCategories = new List<CategoryTree>() };
            if (categoryList.Any(c => c.ParentCategoryId == category.Id) == false)
            {
                
            }
            else
            {
                foreach (var subcat in categoryList.Where(c=>c.ParentCategoryId==category.Id))
                {
                    newCategoryTree.SubCategories.Add(CategoryTree(subcat));
                }
                
            }
            return newCategoryTree;
        }
    }
}
