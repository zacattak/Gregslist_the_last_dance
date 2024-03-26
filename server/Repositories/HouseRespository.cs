namespace gregslist_csharp.Repositories;
public class HouseRepository
{
    private readonly IDbConnection _db;

    public HouseRepository(IDbConnection db)
    {
        _db = db;
    }

    internal House GetHouseById(int houseId)
    {
        string sql = "SELECT * FROM houses WHERE id = @id;";

        House house = _db.Query<House>(sql, new { id = houseId }).FirstOrDefault();
        return house;
    }

    internal List<House> GetHouses()
    {
        string sql = "SELECT * FROM houses;";

        list<House> houses = _db.Query<House>(sql).ToList();
        return houses;
    }
}