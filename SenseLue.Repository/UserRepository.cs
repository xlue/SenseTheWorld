
using SenseLue.Data;
using SenseLue.Data.DBContext;
using SenseLue.Domain.Entity;
using SenseLue.Domain.IRepository;


namespace SenseLue.Repository
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {

    }
}
