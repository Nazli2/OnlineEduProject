using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {
        List<Blog> TGetBlogsWithCategories();
        List<Blog> TGetBlogsByCategoryById(int id);
        Blog TGetBlogWithCategory(int id);
        List<Blog> TGetLast4BlogsWithCategories();
        List<Blog> TGetBlogsWithCategoriesByWriterId(int id);
    }
}
