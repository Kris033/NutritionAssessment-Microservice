using Microsoft.EntityFrameworkCore;
using NutritionAssessment.Dal;
using NutritionAssessment.Service.Dtos.QuicklyTests;
using NutritionAssessment.Service.Interfaces;

namespace NutritionAssessment.Service;

public class QuicklyTestService : IQuicklyTestService
{
    private readonly DbContextOptions<NutritionAssessmentContext> _dbOptions;

    public QuicklyTestService(DbContextOptions<NutritionAssessmentContext> dbOptions)
    {
        _dbOptions = dbOptions;
    }

    #region [Get]
    public async Task<GetPhysicalActivitiesResponse> GetPhysicalActivities(CancellationToken ct = default)
    {
        await using var db = new NutritionAssessmentContext(_dbOptions);

        var physicalActivities = await db.PhysicalActivityLevels
            .Select(x => 
                new GetPhysicalActivitiesListItem 
                { 
                    Id = x.Id,
                    Name = x.Name,
                    Color = x.Color
                })
            .ToListAsync(ct);

        return new GetPhysicalActivitiesResponse
        {
            PhysicalActivities = physicalActivities
        };
    }

    public async Task<GetPassingTestChapterDetailResponse> GetPassingTestChapterDetail(GetPassingTestChapterDetailRequest request, CancellationToken ct = default)
    {
        await using var db = new NutritionAssessmentContext(_dbOptions);

        var chapter = await db.PassingTestChapters
            .Where(x => x.Id == request.NumberChapter)
            .Select(x =>
                new GetPassingTestChapterDetailResponse
                {
                    NumberChapter = x.Id,
                    CountChapters = 0,
                    NameChapter = x.Name,
                    Sections = x.Sections
                        .Select(s =>
                            new GetPassingTestChapterDetailSectionListItem
                            {
                                Id = s.Id,
                                Name = s.Name,
                                OnceDayList = s.OnceDateList
                                    .Select(o =>
                                        new GetPassingTestChapterDetailSectionOnceDayListItem
                                        {
                                            Id = o.PassingTestChapterSectionOnceDate.Id,
                                            Name = o.PassingTestChapterSectionOnceDate.Name
                                        })
                                    .ToList()
                            })
                        .ToList()
                })
            .FirstOrDefaultAsync();
        if (chapter == null)
            throw new NullReferenceException($"{request.NumberChapter} раздел, не был найден");
        return chapter;
    }

    public async Task<GetPassingTestChapterDetailResponse> GetPassingTestChapterSectionDetail(GetPassingTestChapterDetailRequest request, CancellationToken ct = default)
    {
        return new GetPassingTestChapterDetailResponse { };
    }

    public async Task<List<GetDietarySupplementsShortListItem>> GetDietarySupplements(CancellationToken ct = default)
    {
        await using var db = new NutritionAssessmentContext(_dbOptions);

        var dietarySupplements = await db.DietarySupplements
            .Select(x =>
                new GetDietarySupplementsShortListItem
                {
                    Id = x.Id,
                    Name = x.Name,
                    Volume = x.QuicklyChoiseDietarySupplementTemp != null ?
                        new GetDierarySupplementsVolume
                        {
                            TypeVolumeName = x.TypeVolume.Name,
                            Volume = x.QuicklyChoiseDietarySupplement.Volume
                        }
                    : null
                })
            .ToListAsync(ct);

        return dietarySupplements;
    }

    public async Task<GetDietarySupplementDetailResponse> GetDietarySupplementDetail(GetDietarySupplementDetailRequest request, CancellationToken ct = default)
    {
        return new GetDietarySupplementDetailResponse { };
    }

    public async Task<GetResultTestResponse> GetResultTest(CancellationToken ct = default)
    {
        return new GetResultTestResponse { };
    }

    public async Task<GetInformationToCompletedTestResponse> GetInformationToCompletedTest(CancellationToken ct = default)
    {
        return new GetInformationToCompletedTestResponse { };
    }
    #endregion

    #region [Actions]
    public async Task SaveChoisePhysicalActivity(SaveChoisePhysicalActivityRequest request, CancellationToken ct = default)
    {

    }

    public async Task SaveChoiseNutritions(List<SaveChoiseNutritionsRequestListItem> requestItems, CancellationToken ct = default)
    {

    }

    public async Task SaveChoiseDietarySupplement(List<SaveChoiseDietarySupplementRequestListItem> requestItems, CancellationToken ct = default)
    {

    }

    public async Task SaveChoisePhysicalActivityTemp(SaveChoisePhysicalActivityTempRequest request, CancellationToken ct = default)
    {

    }

    public async Task SaveChoiseNutritionsTemp(SaveChoiseNutritionsTempRequest request, CancellationToken ct = default)
    {

    }

    public async Task SaveChoiseDietarySupplementTemp(List<SaveChoiseDietarySupplementTempRequestListItem> requestItems, CancellationToken ct = default)
    {

    }
    #endregion
}
