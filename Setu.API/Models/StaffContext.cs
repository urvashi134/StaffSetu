using Microsoft.EntityFrameworkCore;
using Setu.Entities;

namespace Setu.API.Models
{
    public class StaffContext : DbContext
    {
        internal object tblAttendenceRules;

        public StaffContext(DbContextOptions<StaffContext> options) : base(options)
        {

        }
        public DbSet<tbldepartment> tbldepartment { get; set; }
        public DbSet<tblDesignation>tblDesignation { get; set; }
        public DbSet<tblState> tblState{ get; set; }
        public DbSet<tblCity> tblCity { get; set; }
        public DbSet<tblStaff> tblStaff { get; set; }
        public DbSet<tblSubject> tblSubject { get; set; }
        public DbSet<tblAttendenceRules> tblAttendenceRule { get; set; }
        public DbSet<tblAttendence> tblAttendence { get; set; }
        public DbSet<tblConfirmedAttendence> tblConfirmedAttendences { get; set; }
    }
}
