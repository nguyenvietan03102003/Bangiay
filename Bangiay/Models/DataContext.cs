using Bangiay.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace Bangiay.Models
{
    public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}
		public DbSet<Menu> Menus { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
