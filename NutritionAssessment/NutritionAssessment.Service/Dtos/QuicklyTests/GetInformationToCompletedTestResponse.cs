namespace NutritionAssessment.Service.Dtos.QuicklyTests;

public class GetInformationToCompletedTestResponse
{
    public bool IsBegin { get; set; }

    public bool IsPhysicalActivityCompleted { get; set; }

    public int OnNumberStage { get; set; }

    public bool IsNutritionsCompleted { get; set; }

    public bool IsDietarySupplementsCompleted { get; set; }
}
