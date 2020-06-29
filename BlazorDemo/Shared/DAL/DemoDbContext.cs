using BlazorDemo.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo.Shared.DAL
{
    public class DemoDbContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserContact> UserContacts { get; set; }
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
        : base(options)
        {

        }
       
    }
}
