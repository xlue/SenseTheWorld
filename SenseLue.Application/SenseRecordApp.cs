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
    public class SenseRecordApp
    {
        ISenseRecordRepository service = new SenseRecordRepository();

        public List<SenseRecordEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public SenseRecordEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitForm(SenseRecordEntity senseRecordEntity, string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                senseRecordEntity.Modify(keyValue);
                service.Update(senseRecordEntity);
            }
            else
            {
                senseRecordEntity.Create();
                service.Insert(senseRecordEntity);
            }
        }
    }
}
