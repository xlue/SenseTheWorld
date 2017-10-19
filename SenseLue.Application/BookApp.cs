
using SenseLue.Domain.Entity;
using SenseLue.Domain.IRepository;
using SenseLue.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SenseLue.Application
{
    public class BookApp
    {
        private IBookRepository service = new BookRepository();

        public List<BookEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public BookEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitForm(BookEntity bookEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                bookEntity.Modify(keyValue);
                service.Update(bookEntity);
            }
            else
            {
                bookEntity.Create();
                service.Insert(bookEntity);
            }
        }
    }
}
