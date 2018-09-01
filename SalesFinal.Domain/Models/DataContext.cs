namespace SalesFinal.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<SalesFinal.Common.Models.Product> Products { get; set; }
    }
}
