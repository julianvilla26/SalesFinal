
namespace SalesFinal.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<SalesFinal.Common.Models.Product> Products { get; set; }
    }
}