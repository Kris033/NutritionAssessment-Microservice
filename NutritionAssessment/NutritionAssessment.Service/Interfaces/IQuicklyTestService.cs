using NutritionAssessment.Service.Dtos.QuicklyTests;

namespace NutritionAssessment.Service.Interfaces;

public interface IQuicklyTestService
{
    Task<GetPhysicalActivitiesResponse> GetPhysicalActivities(CancellationToken ct = default);

    Task<GetPassingTestChapterDetailResponse> GetPassingTestChapterDetail(GetPassingTestChapterDetailRequest request, CancellationToken ct = default);

    Task<GetPassingTestChapterDetailResponse> GetPassingTestChapterSectionDetail(GetPassingTestChapterDetailRequest request, CancellationToken ct = default);

    Task<List<GetDietarySupplementsShortListItem>> GetDietarySupplements(CancellationToken ct = default);

    Task<GetDietarySupplementDetailResponse> GetDietarySupplementDetail(GetDietarySupplementDetailRequest request, CancellationToken ct = default);

    Task<GetResultTestResponse> GetResultTest(CancellationToken ct = default);

    Task<GetInformationToCompletedTestResponse> GetInformationToCompletedTest(CancellationToken ct = default);


    Task SaveChoisePhysicalActivity(SaveChoisePhysicalActivityRequest request, CancellationToken ct = default);

    Task SaveChoiseNutritions(List<SaveChoiseNutritionsRequestListItem> requestItems, CancellationToken ct = default);

    Task SaveChoiseDietarySupplement(List<SaveChoiseDietarySupplementRequestListItem> requestItems, CancellationToken ct = default);

    Task SaveChoisePhysicalActivityTemp(SaveChoisePhysicalActivityTempRequest request, CancellationToken ct = default);

    Task SaveChoiseNutritionsTemp(SaveChoiseNutritionsTempRequest request, CancellationToken ct = default);

    Task SaveChoiseDietarySupplementTemp(List<SaveChoiseDietarySupplementTempRequestListItem> requestItems, CancellationToken ct = default);
}