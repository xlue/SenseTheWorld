using SenseLue.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SenseLue.Mapping
{
    public class SenseRecordMap : EntityTypeConfiguration<SenseRecordEntity>
    {
        public SenseRecordMap()
        {
            this.ToTable("Sys_SenseRecord");
            this.HasKey(t => t.F_Id);
        }
    }
}
