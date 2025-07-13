using NutritionAssessment.Core.Entities.PassingQuicklyTests;
using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities;

public class PhysicalActivityLevel
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public string Color { get; set; }

    public EnumPhysicalActivityLevel EnumPhysicalActivityLevel { get; set; }

    public List<QuicklyPassingTestTemp> QuicklyPassingTestTemps { get; set; }

    public List<QuicklyPassingTestResult> QuicklyPassingTestResults { get; set; }
}
