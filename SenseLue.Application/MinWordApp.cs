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
    public class MinWordApp
    {
        private IMinWordRepository service = new MinWordRepository();

        public List<MinWordEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public MinWordEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitForm(MinWordEntity minWordEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                minWordEntity.Modify(keyValue);
                service.Update(minWordEntity);
            }
            else
            {
                minWordEntity.Create();
                service.Insert(minWordEntity);
            }
        }
    }
}
