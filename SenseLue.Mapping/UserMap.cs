using SenseLue.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SenseLue.Mapping
{
    public class UserMap : EntityTypeConfiguration<UserEntity>
    {
        public UserMap()
        {
            this.ToTable("Sys_User");
            this.HasKey(t => t.F_Id);
        }
    }
}
