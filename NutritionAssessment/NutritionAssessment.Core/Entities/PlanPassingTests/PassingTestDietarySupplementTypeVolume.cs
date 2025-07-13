using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestDietarySupplementTypeVolume
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EnumTypeVolume EnumTypeVolume { get; set; }

    public List<DietarySupplement> DietarySupplements { get; set; } = [];
}
