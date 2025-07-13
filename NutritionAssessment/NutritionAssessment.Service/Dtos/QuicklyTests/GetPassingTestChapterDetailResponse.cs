namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetPassingTestChapterDetailResponse
{
    public List<GetPassingTestChapterDetailSectionListItem> Sections { get; set; }

    public int NumberChapter { get; set; }

    public string NameChapter { get; set; }

    public int ChaptersLeft { get; set; }

    public int CountChapters { get; set; }
}