namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSectionOnceDateRelation
{
    public int PassingTestChapterSectionOnceDateId { get; set; }

    public PassingTestChapterSectionOnceDate PassingTestChapterSectionOnceDate { get; set; }

    public int PassingTestChapterSectionId { get; set; }

    public PassingTestChapterSection PassingTestChapterSection { get; set; }
}
