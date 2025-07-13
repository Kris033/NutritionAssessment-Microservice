using NutritionAssessment.Core.Entities.PassingQuicklyTests;
using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestDietarySupplementOnceDate
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EnumOnceDate OnceDate { get; set; }

    public List<PassingTestDietarySupplementOnceDateRelation> DietarySupplements { get; set; } = [];

    public QuicklyChoiseDietarySupplementTemp? QuicklyChoiseDietarySupplementTemp { get; set; }

    public QuicklyChoiseDietarySupplement? QuicklyChoiseDietarySupplement { get; set; }
}
