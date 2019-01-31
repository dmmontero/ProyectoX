namespace DAL
{
    using DAL.Modelos;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Defines the <see cref="SchoolContext" />
    /// </summary>
    internal class SchoolContext : DbContext
    {
        /// <summary>
        /// Gets or sets the Students
        /// </summary>
        public DbSet<Student> Students { get; set; }

        /// <summary>
        /// Gets or sets the Courses
        /// </summary>
        public DbSet<Grade> Grades { get; set; }

        /// <summary>
        /// The OnConfiguring
        /// </summary>
        /// <param name="optionsBuilder">The optionsBuilder<see cref="DbContextOptionsBuilder"/></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=DNPWP38104\MSSQLSERVER_2016;Database=SchoolDB;Trusted_Connection=True;");
        }
    }
}
