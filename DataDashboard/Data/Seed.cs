using CsvHelper;
using System.Globalization;
using DataDashboard.Models;

namespace DataDashboard.Data.Seed;
public static class Seed
{
    public static void seed(AppDbContext context)
    {
        if(context.StudentSocialMedias.Any())
        {
            return;
        }
        using var reader = new StreamReader("Data/Students.csv");
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<StudentSocialMediaMap>();
        var records = csv.GetRecords<StudentSocialMedia>().ToList();
        context.StudentSocialMedias.AddRange(records);
        context.SaveChanges();
    }
}