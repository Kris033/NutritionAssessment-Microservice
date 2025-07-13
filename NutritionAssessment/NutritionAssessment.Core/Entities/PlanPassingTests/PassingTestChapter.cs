namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapter
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<PassingTestChapterSection> Sections { get; set; } = [];
}
