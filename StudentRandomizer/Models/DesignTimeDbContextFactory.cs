using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace StudentRandomizer.Models
{
  public class ToDoListContextFactory : IDesignTimeDbContextFactory<StudentRandomizerContext>
  {

    StudentRandomizerContext IDesignTimeDbContextFactory<StudentRandomizerContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<StudentRandomizerContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new StudentRandomizerContext(builder.Options);
    }
  }
}