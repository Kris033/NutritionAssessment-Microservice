using NutritionAssessment.Core.Entities.PassingQuicklyTests;
using NutritionAssessment.Core.Entities.PlanPassingTests;

namespace NutritionAssessment.Core.Entities;

public class DietarySupplement
{
    public long Id { get; set; }

    public string Name { get; set; }

    public int TypeVolumeId { get; set; }

    public PassingTestDietarySupplementTypeVolume TypeVolume { get; set; }

    public List<PassingTestDietarySupplementOnceDateRelation> OnceDates { get; set; } = [];

    public QuicklyChoiseDietarySupplement? QuicklyChoiseDietarySupplement { get; set; }

    public QuicklyChoiseDietarySupplementTemp? QuicklyChoiseDietarySupplementTemp { get; set; }

}
