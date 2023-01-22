using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    //public  DbSet<Name_is_Class> Name_table (get; set;)
    public  DbSet<Country> Countrys{ get; set; }
    public  DbSet<DepartMent> DepartMents{ get; set; }
    public  DbSet<Employee> Employees{ get; set; }
    public  DbSet<Job> Jobs{ get; set; }
    public  DbSet<JobGrade> JobGrades{ get; set; }
    public  DbSet<JobHistory> JobHistorys{ get; set; }
    public  DbSet<Location> Locations{ get; set; }
    public  DbSet<Region> Regions{ get; set; }
}
