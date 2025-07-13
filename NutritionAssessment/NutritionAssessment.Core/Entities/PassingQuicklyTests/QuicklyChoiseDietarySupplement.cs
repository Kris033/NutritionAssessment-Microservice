using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyChoiseDietarySupplement
{
    public long DietarySupplementId { get; set; }

    public DietarySupplement DietarySupplement { get; set; } 

    public int OnceDateId { get; set; }

    public PassingTestDietarySupplementOnceDate PassingTestDietarySupplementOnceDate { get; set; }

    public decimal Volume { get; set; }

    public QuicklyPassingTestResult QuicklyPassingTestResult { get; set; }

    public Guid QuicklyPassingTestResultId { get; set; }
}
