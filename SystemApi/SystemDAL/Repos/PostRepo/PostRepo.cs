using SystemApi.SystemDAL.Context;

namespace SystemApi.SystemDAL.Repos.PostRepo
{
    public class PostRepo : IPostRepo
    {
        private readonly SytemDbContext dbContext;

        public PostRepo(SytemDbContext sytemDbContext)
        {
            this.dbContext = sytemDbContext;
        }

        public bool Add(PostDto post)
        {
            var pst = new Models.Post();
            pst.Name = post.Name;
            pst.UserId = post.UserId;
            dbContext.Posts.Add(pst);
            var save = dbContext.SaveChanges();
            return save > 1 ? true : false;
        }

       
    }
}
