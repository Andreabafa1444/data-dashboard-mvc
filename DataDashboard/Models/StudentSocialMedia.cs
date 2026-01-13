public class StudentSocialMedia
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int Age { get; set; }

    public string Gender { get; set; } = string.Empty;
    public string AcademicLevel { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;

    public decimal AvgDailyUsageHours { get; set; }
    public string MostUsedPlatform { get; set; } = string.Empty;

    public bool AffectsAcademicPerformance { get; set; }
    public decimal SleepHoursPerNight { get; set; }
    public int MentalHealthScore { get; set; }
    public string RelationshipStatus { get; set; } = string.Empty;
    public int ConflictsOverSocialMedia { get; set; }
    public int AddictionScore { get; set; }
}
