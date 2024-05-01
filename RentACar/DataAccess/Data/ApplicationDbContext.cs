using Microsoft.EntityFrameworkCore;
using RentACar_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

                
        }

        public DbSet<Vehicle> vehicles { get; set; }
        public DbSet<User> users { get; set; }
    }
}
