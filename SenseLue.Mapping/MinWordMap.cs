using SenseLue.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SenseLue.Mapping
{
    public class MinWordMap : EntityTypeConfiguration<MinWordEntity>
    {
        public MinWordMap()
        {
            this.ToTable("Sys_MinWord");
            this.HasKey(t => t.F_Id);
        }
    }
}
