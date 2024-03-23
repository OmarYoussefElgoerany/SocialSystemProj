using SystemApi.SystemDAL.Models;

namespace SystemApi.SystemDAL.Repos.UserRepo
{
    public interface IUserRepo
    {
        List<User>? GetAllUserPosts(int page, int countPerPage);
    }
}
