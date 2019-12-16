namespace ManagementCoffeShop.Core.Data.Context
{
    using ManagementCoffeShop.Core.Interfaces;
    using ManagementCoffeShop.Core.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Reflection;
    using System.Threading.Tasks;

    public class CoffeShopContext : DbContext, ICoffeShopContext
    {
        public CoffeShopContext()
        {
            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = false;
            (this as IObjectContextAdapter).ObjectContext.ContextOptions.UseCSharpNullComparisonBehavior = true;
            this.Database.Connection.StateChange += Connection_StateChange;
        }
        void Connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            // Set ANSI_NULLS OFF when any connection is opened. This is needed because of a bug in Entity Framework
            // that is not fixed in EF 5 when using DbContext.
            if (e.CurrentState == System.Data.ConnectionState.Open)
            {
                var connection = (System.Data.Common.DbConnection)sender;
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "SET ANSI_NULLS OFF";
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public virtual DbSet<Employe> Employes { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Area> Areas { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<RawMaterial> RawMaterials { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Tables> Tables { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<BillSell> BillSells { get; set; } 
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DetailBillSell> DetailBillSells { get; set; }
     //   public virtual DbSet<Bill_DetailBill> Bill_DetailBills { get; set; }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        //public override Task<int> s()
        //{
        //    try
        //    {
        //        return base.SaveChangesAsync();
        //    }
        //    catch (DbEntityValidationException ex)
        //    {
        //        // Retrieve the error messages as a list of strings.
        //        var errorMessages = ex.EntityValidationErrors
        //            .SelectMany(x => x.ValidationErrors)
        //            .Select(x => x.ErrorMessage);

        //        // Join the list to a single string.
        //        var fullErrorMessage = string.Join("; ", errorMessages);

        //        // Combine the original exception message with the new one.
        //        var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

        //        // Throw a new DbEntityValidationException with the improved exception message.
        //        throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
        //    }
        //}

        /// <inheritdoc />
        public void RollBack()
        {
            foreach (var entry in base.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Modified:
                        entry.State = EntityState.Unchanged;
                        break;
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Deleted:
                        // Note - problem with deleted entities:
                        // When an entity is deleted its relationships to other entities are severed. 
                        // This includes setting FKs to null for nullable FKs or marking the FKs as conceptually null (don’t ask!) 
                        // if the FK property is not nullable. You’ll need to reset the FK property values to 
                        // the values that they had previously in order to re-form the relationships. 
                        // This may include FK properties in other entities for relationships where the 
                        // deleted entity is the principal of the relationship–e.g. has the PK 
                        // rather than the FK. I know this is a pain–it would be great if it could be made easier in the future, but for now it is what it is.
                        entry.State = EntityState.Unchanged;
                        break;
                }
            }
        }

        public void Entry(object entity)
        {
            var entry = base.Entry(entity);
            if (entry.State == EntityState.Detached || entry.State == EntityState.Modified)
            {
                entry.State = EntityState.Unchanged; //do it here

              //  base.Set<object>().Attach(entity); //attach

                //base.SaveChanges(); //save it
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // http://stackoverflow.com/questions/7924758/entity-framework-creates-a-plural-table-name-but-the-view-expects-a-singular-ta
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrWhiteSpace(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                               && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));

            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }

    }
}
