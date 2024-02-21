using KodlamaIOWebDesignHomework.Entities;
using KodlamaIOWebDesignHomework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.DataAccess;

class CategoryData : ICategory
{
    List<Categories> categoryList;

    public CategoryData()
    {
        categoryList = new List<Categories>
        {
            new Categories() {CategoryId = 1, CategoryName = "C#"},
            new Categories() {CategoryId = 2, CategoryName = "Java"},
            new Categories() {CategoryId = 3, CategoryName = "Phyton"}
        };
    }

    public void AddCategory(Categories category)
    {
        categoryList.Add(category);
    }

    public void RemoveCategory(Categories category)
    {
        categoryList.Remove(category);
    }

    public void UpdateCategory(Categories category)
    {
        var tempCategoryId = categoryList.FirstOrDefault(cat => cat.CategoryId == category.CategoryId);

        if(tempCategoryId != null)
        {
            tempCategoryId.CategoryId = category.CategoryId;
            tempCategoryId.CategoryName = category.CategoryName;
        }
    }

    public List<Categories> GetCategoryList()
    {
        Console.WriteLine("Tüm Kategoriler");
        foreach (var item in categoryList)
        {
            Console.WriteLine($"{item.CategoryId}: {item.CategoryName}");
        }
        return categoryList;
    }
}
