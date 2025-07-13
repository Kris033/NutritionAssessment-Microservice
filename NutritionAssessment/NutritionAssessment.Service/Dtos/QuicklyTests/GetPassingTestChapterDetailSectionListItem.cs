namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetPassingTestChapterDetailSectionListItem
{
    public int Id { get; set; }

    public string Name { get; set; }

    public List<GetPassingTestChapterDetailSectionOnceDayListItem> OnceDayList { get; set; }
}
