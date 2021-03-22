using Microsoft.EntityFrameworkCore;

namespace ApiSQLDes05.Models
{
    public class GendAccAplExtCon : DbContext

    {
        public GendAccAplExtCon(DbContextOptions options) : base (options)
        {

        }

        public DbSet<GendAccAplExt> GendAccAplExts { get; set; }
        
    }
}