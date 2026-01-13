using CsvHelper.Configuration;
using DataDashboard.Models;

namespace DataDashboard.Data.Seed;

public sealed class StudentSocialMediaMap : ClassMap<StudentSocialMedia>
{
    public StudentSocialMediaMap()
    {
        Map(m => m.StudentId).Name("Student_ID");
        Map(m => m.Age).Name("Age");
        Map(m => m.Gender).Name("Gender");
        Map(m => m.AcademicLevel).Name("Academic_Level");
        Map(m => m.Country).Name("Country");
        Map(m => m.AvgDailyUsageHours).Name("Avg_Daily_Usage_Hours");
        Map(m => m.MostUsedPlatform).Name("Most_Used_Platform");

        Map(m => m.AffectsAcademicPerformance)
            .Name("Affects_Academic_Performance")
            .Convert(args =>
                args.Row.GetField("Affects_Academic_Performance") == "Yes");

        Map(m => m.SleepHoursPerNight).Name("Sleep_Hours_Per_Night");
        Map(m => m.MentalHealthScore).Name("Mental_Health_Score");
        Map(m => m.RelationshipStatus).Name("Relationship_Status");
        Map(m => m.ConflictsOverSocialMedia).Name("Conflicts_Over_Social_Media");
        Map(m => m.AddictionScore).Name("Addicted_Score");
    }
}
