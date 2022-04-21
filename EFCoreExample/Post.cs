using System;
namespace EFCoreExample
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        // Propiedad de navegación: Con esto se hace la referencia a la otra tabla (Foreign Key)
        public int BlogId { get; set; }
        // Con esto podríamos decir algo como post.Blog.Url
        public Blog Blog { get; set; }
    }
}
