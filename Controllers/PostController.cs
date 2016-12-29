using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace webapi.Controllers{
    [Route("api/[controller]")]
    public class PostController:Controller{
        public PostController()
        {
            
        }
        [HttpGet]
        public IEnumerable<Models.Post> Get(){
            List<Models.Post> posts = new List<Models.Post>();
            posts.Add(new Models.Post(){Id = -4, author = "Matthew", text = "1st book"});
            posts.Add(new Models.Post(){Id = -3, author = "Mark", text = "2nd book"});
            posts.Add(new Models.Post(){Id = -2, author = "Luke", text = "3rd book"});
            posts.Add(new Models.Post(){Id = -1, author = "John", text = "4th book"});
            return posts;
        }
    }
}