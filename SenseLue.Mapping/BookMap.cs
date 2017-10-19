using SenseLue.Domain.Entity;
using System.Data.Entity.ModelConfiguration;

namespace SenseLue.Mapping
{
    public class BookMap : EntityTypeConfiguration<BookEntity>
    {
        public BookMap()
        {
            this.ToTable("Sys_Book");
            this.HasKey(t => t.F_Id);
        }
    }
}
