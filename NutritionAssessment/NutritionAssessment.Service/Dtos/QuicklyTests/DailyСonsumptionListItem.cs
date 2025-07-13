namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class DailyСonsumptionListItem
{
    public string Name { get; set; }

    public decimal VolumeNow { get; set; }

    public decimal VolumeNormallyFrom { get; set; }

    public decimal? VolumeNormallyTo { get; set; }

    public string VolumeTypeName { get; set; }
}
