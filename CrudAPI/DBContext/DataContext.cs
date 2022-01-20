using Microsoft.EntityFrameworkCore;

namespace CrudAPI
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}