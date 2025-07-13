using NutritionAssessment.Core.Enums;

namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestChapterSectionVolumeType
{
    public int Id { get; set; }

    public string Name { get; set; }

    public EnumTypeVolume TypeVolume { get; set; }

    public List<PassingTestChapterSection> Sections { get; set; } = [];
}