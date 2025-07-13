namespace NutritionAssessment.Core.Entities.PassingQuicklyTests;

public class QuicklyPassingTestResult
{
    public Guid Id { get; set; }

    public int PhysicalActivityLevelId { get; set; }

    public PhysicalActivityLevel PhysicalActivityLevel { get; set; }

    public List<QuicklyChoiseSection> ChoiseSections { get; set; } = [];

    public List<QuicklyChoiseDietarySupplement> QuicklyChoiseDietarySupplements { get; set; } = [];

    public DateTime DateTimeCompleted { get; set; }
}
