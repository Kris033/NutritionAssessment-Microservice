namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetPassingTestChapterSectionDetailResponse
{
    public int SectionId { get; set; }

    public string Name { get; set; }

    public string UrlImage { get; set; }

    public string TypeVolume { get; set; }

    public List<int> Volumes { get; set; } = [];
}