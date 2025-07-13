using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyChoiseDietarySupplementTemp
{
    public long DietarySupplementId { get; set; }

    public DietarySupplement DietarySupplement { get; set; }

    public int OnceDateId { get; set; }

    public PassingTestDietarySupplementOnceDate PassingTestDietarySupplementOnceDate { get; set; }

    public decimal Volume { get; set; }

    public QuicklyPassingTestTemp QuicklyPassingTestTemp { get; set; }

    public Guid QuicklyPassingTestTempId { get; set; }
}
