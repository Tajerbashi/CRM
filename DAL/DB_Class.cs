using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BEE;
namespace DAL
{
    public class DB_Class : DbContext
    {
        public DB_Class() : base("name=DBC"){}

        public DbSet<User> users { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<InVoice> inVoices { get; set; }
        public DbSet<Activity> activities { get; set; }
        public DbSet<ActivityCategory> activityCategories { get; set; }
        public DbSet<Reminder> reminders { get; set; }
        public DbSet<UserGroup> userGroups { get; set; }
        public DbSet<UserAccessRole> accessRoles { get; set; }

    }
}
