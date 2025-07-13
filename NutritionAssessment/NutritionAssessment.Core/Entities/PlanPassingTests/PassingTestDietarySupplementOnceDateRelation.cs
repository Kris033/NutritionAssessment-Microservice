namespace NutritionAssessment.Core.Entities.PlanPassingTests;

public class PassingTestDietarySupplementOnceDateRelation
{
    public long DietarySupplementId { get; set; }

    public DietarySupplement DietarySupplement { get; set; }

    public int PassingTestDietarySupplementOnceDateId { get; set; }

    public PassingTestDietarySupplementOnceDate PassingTestDietarySupplementOnceDate { get; set; }
}
