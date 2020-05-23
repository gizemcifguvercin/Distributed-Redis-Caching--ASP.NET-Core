using System.Collections.Generic;
using System.Threading.Tasks;

namespace RedisExampleNetCore.Controllers
{
    public class CityService
    {
        public static IEnumerable<City> GetCities(string countryId)
        {
            return new List<City>
            {
                new City(){ CityId ="01", CityName ="Adana"},
                new City(){CityId ="34" ,CityName="İstanbul" }
            };
        }
    }
}
