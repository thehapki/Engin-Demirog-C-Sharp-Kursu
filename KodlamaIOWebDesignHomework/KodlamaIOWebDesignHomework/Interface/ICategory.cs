using KodlamaIOWebDesignHomework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOWebDesignHomework.Interface;

interface ICategory
{
    public void AddCategory(Categories category);
    public void RemoveCategory(Categories category);
    public void UpdateCategory(Categories category);

    List<Categories> GetCategoryList();
}
