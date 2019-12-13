namespace ManagementCoffeShop.Core.Data.Mapping
{
    using ManagementCoffeShop.Core.Models.Entities;
    using System.Data.Entity.ModelConfiguration;

    public class EmployeMapping : EntityTypeConfiguration<Employe>
    {
       public EmployeMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
            Property(x => x.userName).IsRequired().HasMaxLength(100);
            Property(x => x.password).IsRequired().HasMaxLength(100);
            Property(x => x.fullName).IsRequired().HasMaxLength(100);
            Property(x => x.sex).IsRequired();
            Property(x => x.birthDay).IsRequired();
            Property(x => x.address).IsRequired().HasMaxLength(500);
            Property(x => x.phoneNumber).IsRequired().HasMaxLength(11);
            Property(x => x.email).IsOptional();
            Property(x => x.dayAtWork).IsRequired();
            Property(x => x.statusOfWork).IsRequired();
            Property(x => x.createDate).IsRequired();
            Property(x => x.updateDate).IsRequired();

            HasRequired(x => x.Offices)
                .WithMany(t => t.User)
                .Map(x => x.MapKey("Employe_Id"))
                .WillCascadeOnDelete(false);
        }
    }
}
