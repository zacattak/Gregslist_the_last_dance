namespace gregslist_csharp.Controllers;


[ApiController]
[Route("api/[controller]")]

public class HouseController : ControllerBase
{
    private readonly HouseService _houseService;

    public HouseController(HouseService houseService)

    {
        _houseService = houseService
    }

    [HttpGet]

    public ActionResult<List><House>> GetHouses()
    {
        try
        {
            List<House> houses = _houseService.GetHouses();
            return Ok(houses);
        }
        catch (Exception exception)
        {

            return BadRequest(exception.Message);
        }
    }

    [HttpGet("{houseId}")]
    public ActionResult<House> GetHouseById(int houseId)
    {
        try
        {
            House house = _houseService.GetHouseById(houseId)
            return Ok(house);
        }
        catch (Exception exception)
        {

            return BadRequest(exception.Message);
        }
    }
}
