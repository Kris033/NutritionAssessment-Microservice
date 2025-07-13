namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetDietarySupplementDetailResponse
{
    public int DietarySupplementId { get; set; }

    public string DietarySupplementName { get; set; }

    public string VolumeTypeName { get; set; }

    public List<GetDietarySupplementDetailOnceDayListItem> OnceDayItems { get; set; } = [];
}
