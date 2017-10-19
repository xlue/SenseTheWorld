using SenseLue.Code;
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
    public class UserApp
    {
        private IUserRepository service = new UserRepository();

        public List<UserEntity> GetList()
        {
            return service.IQueryable().ToList();
        }

        public UserEntity GetForm(string keyValue)
        {
            return service.FindEntity(keyValue);
        }

        public void DeleteForm(string keyValue)
        {
            service.Delete(t => t.F_Id == keyValue);
        }

        public void SubmitForm(UserEntity userEntity,string keyValue)
        {
            if (!string.IsNullOrEmpty(keyValue))
            {
                userEntity.Modify(keyValue);
                service.Update(userEntity);
            }
            else
            {
                userEntity.Create();
                service.Insert(userEntity);
            }
        }

        public UserEntity CheckLogin(string username, string password)
        {
            UserEntity userEntity = service.FindEntity(t => t.F_Account == username);
            if (userEntity != null)
            {
                if (userEntity.F_EnabledMark == true)
                {
                    string dbPassword = userEntity.F_Email;
                    if (dbPassword == password)
                    {
                        return userEntity;
                    }
                    else
                    {
                        throw new Exception("密码不正确，请重新输入");
                    }
                }
                else
                {
                    throw new Exception("账户被系统锁定,请联系管理员");
                }
            }
            else
            {
                throw new Exception("账户不存在，请重新输入");
            }
        }


    }
}
