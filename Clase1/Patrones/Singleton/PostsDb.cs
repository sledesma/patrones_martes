using System;
using System.Collections.Generic;

namespace Patrones.Singleton {

    class Post {
        public string title { get; set; }
        public string body { get; set; }

        public Post(string title, string body) {
            this.title = title;
            this.body = body;
        }
    }
    class PostsDb {

        private static List<Post> data;

        private static PostsDb instance;

        private PostsDb() {
            Console.Write("Creando la lista");
            PostsDb.data = new List<Post>();

            for (int i = 0; i < 10; i++)
            {
                PostsDb.data.Add(new Post("Titulo "+i, "Cuerpo "+i));
            }
        }

        public static List<Post> GetPosts() {
            if(PostsDb.instance == null) {
                PostsDb.instance = new PostsDb();
            }
            return PostsDb.data;
        }

    }

}