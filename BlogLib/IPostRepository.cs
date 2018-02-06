using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IPostRepository
    {
        List<Post> ListAll();
        Post GetById(int id);
        void Add(Post newPost);
        void Update(Post updatedPost);
        void Delete(int id);
    }
}
