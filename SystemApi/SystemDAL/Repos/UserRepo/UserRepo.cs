using Microsoft.EntityFrameworkCore;
using SystemApi.SystemDAL.Context;
using SystemApi.SystemDAL.Models;

namespace SystemApi.SystemDAL.Repos.UserRepo
{
    public class UserRepo:IUserRepo
    {
        private readonly SytemDbContext dbContext;

        public UserRepo(SytemDbContext sytemDbContext )
        {
            this.dbContext = sytemDbContext;   
        }

        public List<User>? GetAllUserPosts(int page, int countPerPage)
        {
            return dbContext.Users.Include(i => i.Posts).
                OrderBy(i=> i.Id).
               Skip((page-1) * countPerPage).
               Take(countPerPage).ToList();
           
        }
    }
}
