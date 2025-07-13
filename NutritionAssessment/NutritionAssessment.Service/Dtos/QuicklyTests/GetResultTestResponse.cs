namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetResultTestResponse
{
    public List<DailyСonsumptionListItem> NormDailyConsumptionItems { get; set; } = [];

    public List<DailyСonsumptionListItem> DeficiteDailyConsumptionItems { get; set; } = [];

    public List<NewDailyСonsumptionListItem> NewDailyСonsumptionItems { get; set; } = [];
}