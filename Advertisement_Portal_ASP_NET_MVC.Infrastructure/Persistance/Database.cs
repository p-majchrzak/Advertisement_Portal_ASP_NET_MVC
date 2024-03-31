using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Portal_ASP_NET_MVC.Infrastructure.Persistance
{
    public class Database : DbContext
    {
        public DbSet<Domain.Entities.AdminLogginData> AdminLogginData_Table { get; set;}
        public DbSet<Domain.Entities.Alert> Alert_Table { get; set;}
        public DbSet<Domain.Entities.Announcement> Announcement_Table { get; set;}
        public DbSet<Domain.Entities.AnnouncementSkills> AnnouncementSkills_Table { get; set;}
        public DbSet<Domain.Entities.Applications> Applications_Table { get; set;}
        public DbSet<Domain.Entities.ApplicationsHistory> ApplicationsHistory_Table { get; set;}
        public DbSet<Domain.Entities.Categories> Categories_Table { get; set;}
        public DbSet<Domain.Entities.Education> Educations_Table { get; set;}
        public DbSet<Domain.Entities.Experience> Experience_Table_Table { get; set;}
        public DbSet<Domain.Entities.FirmData> FirmData_Table { get; set;}
        public DbSet<Domain.Entities.FirmLogginData> FirmLogginData_Table { get; set;}
        public DbSet<Domain.Entities.Interests> Interests_Table { get; set;}
        public DbSet<Domain.Entities.Languages> Languages_Table { get; set;}
        public DbSet<Domain.Entities.Message> Message_Table { get; set;}
        public DbSet<Domain.Entities.ReportedAccount> ReportedAccounts_Table { get; set;}
        public DbSet<Domain.Entities.ReportedAd> ReportedAd_Table { get; set;}
        public DbSet<Domain.Entities.SavedAnnouncement> SavedAnnouncements_Table { get; set;}
        public DbSet<Domain.Entities.Skills> Skills_Table { get; set;}
        public DbSet<Domain.Entities.Subcategory> Subcategory_Table { get; set;}
        public DbSet<Domain.Entities.UserData> UserData_Table { get; set;}
        public DbSet<Domain.Entities.UserLogginData> UserLogginData_Table { get; set;}
        public Database(DbContextOptions<Database> options) : base(options)
        {

        }
    }
}
