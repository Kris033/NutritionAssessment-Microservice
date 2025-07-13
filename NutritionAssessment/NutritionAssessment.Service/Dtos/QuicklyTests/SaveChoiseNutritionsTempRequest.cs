namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class SaveChoiseNutritionsTempRequest
{
    public int NumberChapter { get; set; }

    public List<SaveChoiseNutritionsTempListItem> Sections { get; set; } = [];
}
