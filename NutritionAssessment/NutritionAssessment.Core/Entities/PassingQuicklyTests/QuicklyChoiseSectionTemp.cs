using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyChoiseSectionTemp
{
    public int SectionId { get; set; }

    public PassingTestChapterSection PassingTestChapterSection { get; set; }

    public int OnceDateId { get; set; }

    public PassingTestChapterSectionOnceDate PassingTestChapterSectionOnceDate { get; set; }

    public decimal Volume { get; set; }

    public QuicklyPassingTestTemp QuicklyPassingTestTemp { get; set; }

    public Guid QuicklyPassingTestTempId { get; set; }
}
