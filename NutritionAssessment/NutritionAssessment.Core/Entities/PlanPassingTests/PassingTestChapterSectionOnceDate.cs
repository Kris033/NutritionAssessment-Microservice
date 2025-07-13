using NutritionAssessment.Core.Entities.PassingQuicklyTests;
using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSectionOnceDate
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EnumOnceDate OnceDate { get; set; }

    public List<PassingTestChapterSectionOnceDateRelation> Sections { get; set; } = [];

    public QuicklyChoiseSection? QuicklyChoiseSection { get; set; }

    public QuicklyChoiseSectionTemp? QuicklyChoiseSectionTemp { get; set; }
}
