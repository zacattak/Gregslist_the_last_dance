namespace gregslist_csharp.Services;

public class HouseService
{
    private readonly HouseRepository _repository;

    public HouseService(HouseRepository repository)
    {
        _repository = repository
    }

    internal House GetHouseById(int houseId)
    {
        House house = _repository.GetHouseById(houseId);

        if (house == null)
        {
            throw new Exception($"Invalid id: {houseId}");
        }

        return house;
    }

    internal List<House> GetHouses()
    {
        List<House> houses = _repository.GetHouses();
        return houses;
    }
}