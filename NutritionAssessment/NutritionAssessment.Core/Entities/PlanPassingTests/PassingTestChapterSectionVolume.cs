namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSectionVolume
{
    public int Id { get; set; }

    public decimal CountVolume { get; set; }

    public List<PassingTestChapterSectionVolumeRelation> Sections { get; set; } = [];
}