using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/cinemas")]
public class CinemaController : ControllerBase
{
    private readonly ICinemaService _cinemaService;

    public CinemaController(ICinemaService cinemaService)
    {
        _cinemaService = cinemaService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCinemas()
    {
        var cinemas = await _cinemaService.GetCinemas();

        return Ok(cinemas);
    }
}