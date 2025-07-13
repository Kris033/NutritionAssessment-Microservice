using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyChoiseSection
{
    public int SectionId { get; set; }

    public PassingTestChapterSection PassingTestChapterSection { get; set; }

    public int OnceDateId { get; set; }

    public PassingTestChapterSectionOnceDate PassingTestChapterSectionOnceDate { get; set; }

    public decimal Volume { get; set; }

    public QuicklyPassingTestResult QuicklyPassingTestResult { get; set; }

    public Guid QuicklyPassingTestResultId { get; set; }
}
