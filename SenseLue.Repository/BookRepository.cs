using SenseLue.Data;
using SenseLue.Domain.Entity;
using SenseLue.Domain.IRepository;


namespace SenseLue.Repository
{
    public class BookRepository : RepositoryBase<BookEntity>, IBookRepository
    {
    }
}
