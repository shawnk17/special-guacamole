using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BlogLib
{
    public class BlogRepositoryEf : IBlogRepository
    {
        private readonly BloggingContext _dbContext;

        public BlogRepositoryEf(BloggingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Blog newBlog)
        {
            _dbContext.Add(newBlog);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
        }

        public Blog GetById(int id)
        {
            return new Blog();
        }

        public List<Blog> ListAll()
        {
            return _dbContext.Blogs.ToList();
        }

        public void Update(Blog updatedBlog)
        {
        }
    }
}
