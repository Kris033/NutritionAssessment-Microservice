namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSectionVolumeRelation
{
    public int PassingTestChapterSectionVolumeId { get; set; }

    public PassingTestChapterSectionVolume PassingTestChapterSectionVolume { get; set; }

    public int PassingTestChapterSectionId { get; set; }

    public PassingTestChapterSection PassingTestChapterSection { get; set; }
}
