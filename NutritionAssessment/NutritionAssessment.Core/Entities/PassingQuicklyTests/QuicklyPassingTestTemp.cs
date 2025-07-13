using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyPassingTestTemp
{
    public Guid Id { get; set; }

    public bool IsBegin { get; set; }

    public int? PhysicalActivityLevelId { get; set; }

    public PhysicalActivityLevel PhysicalActivityLevel { get; set; }

    public bool IsPhysicalActivityCompleted { get; set; }

    public List<QuicklyChoiseSectionTemp> ChoiseSections { get; set; } = [];

    public int OnNumberStage { get; set; }

    public bool IsNutritionsCompleted { get; set; }

    public List<QuicklyChoiseDietarySupplementTemp> QuicklyChoiseDietarySupplements { get; set; } = [];

    public bool IsDietarySupplementsCompleted { get; set; }

    public DateTime? LastUpdated { get; set; }
}
