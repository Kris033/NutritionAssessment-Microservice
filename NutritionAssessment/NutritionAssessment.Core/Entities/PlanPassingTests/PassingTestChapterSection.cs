using NutritionAssessment.Core.Entities.PassingQuicklyTests;

namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSection
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string UrlImage { get; set; }

    public int ChapterId { get; set; }

    public PassingTestChapter Chapter { get; set; }

    public int TypeVolumeId { get; set; }

    public PassingTestChapterSectionVolumeType TypeVolume { get; set; }

    public List<PassingTestChapterSectionVolumeRelation> Volumes { get; set; } = [];

    public List<PassingTestChapterSectionOnceDateRelation> OnceDateList { get; set; } = [];

    public QuicklyChoiseSectionTemp? QuicklyChoiseSectionTemp { get; set; }

    public QuicklyChoiseSection? QuicklyChoiseSection { get; set; }
}