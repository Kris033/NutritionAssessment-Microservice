using Microsoft.AspNetCore.Mvc;
using NutritionAssessment.Service.Dtos.QuicklyTests;
using NutritionAssessment.Service.Interfaces;

namespace NutritionAssessment.WebApi.Controllers;

[ApiController]
[Route("api/v1/[Controller]/[Action]")]
public class QuicklyTestController : Controller
{
    private readonly IQuicklyTestService _quicklyTestService;

    public QuicklyTestController(IQuicklyTestService quicklyTestService)
    {
        _quicklyTestService = quicklyTestService;
    }

    [HttpGet]
    public async Task<ActionResult<GetPhysicalActivitiesResponse>> GetPhysicalActivities(CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetPhysicalActivities(ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPassingTestChapterDetailResponse>> GetPassingTestChapterDetail([FromRoute] GetPassingTestChapterDetailRequest request, CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetPassingTestChapterDetail(request, ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetPassingTestChapterDetailResponse>> GetPassingTestChapterSectionDetail([FromRoute] GetPassingTestChapterDetailRequest request, CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetPassingTestChapterSectionDetail(request, ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetDietarySupplementsShortListItem>>> GetDietarySupplements(CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetDietarySupplements(ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetDietarySupplementDetailResponse>> GetDietarySupplementDetail([FromRoute] GetDietarySupplementDetailRequest request, CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetDietarySupplementDetail(request, ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetResultTestResponse>> GetResultTest(CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetResultTest(ct);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetInformationToCompletedTestResponse>> GetInformationToCompletedTest(CancellationToken ct = default)
    {
        var response = await _quicklyTestService.GetInformationToCompletedTest(ct);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoisePhysicalActivity(SaveChoisePhysicalActivityRequest request, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoisePhysicalActivity(request, ct);
        return NoContent();
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoiseNutritions(List<SaveChoiseNutritionsRequestListItem> requestItems, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoiseNutritions(requestItems, ct);
        return NoContent();
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoiseDietarySupplement(List<SaveChoiseDietarySupplementRequestListItem> requestItems, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoiseDietarySupplement(requestItems, ct);
        return NoContent();
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoisePhysicalActivityTemp(SaveChoisePhysicalActivityTempRequest request, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoisePhysicalActivityTemp(request, ct);
        return NoContent();
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoiseNutritionsTemp(SaveChoiseNutritionsTempRequest request, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoiseNutritionsTemp(request, ct);
        return NoContent();
    }

    [HttpPut]
    public async Task<ActionResult> SaveChoiseDietarySupplementTemp(List<SaveChoiseDietarySupplementTempRequestListItem> requestItems, CancellationToken ct = default)
    {
        await _quicklyTestService.SaveChoiseDietarySupplementTemp(requestItems, ct);
        return NoContent();
    }
}
