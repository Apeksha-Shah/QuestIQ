using Microsoft.EntityFrameworkCore;
using QuizApplicationMVC.Models;

namespace QuizApplicationMVC.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}