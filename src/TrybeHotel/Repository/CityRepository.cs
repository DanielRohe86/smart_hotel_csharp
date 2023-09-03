using TrybeHotel.Models;
using TrybeHotel.Dto;

namespace TrybeHotel.Repository
{
    public class CityRepository : ICityRepository
    {
        protected readonly ITrybeHotelContext _context;
        public CityRepository(ITrybeHotelContext context)
        {
            _context = context;
        }

        public IEnumerable<CityDto> GetCities()
        {
           return _context.Cities.Select(city => new CityDto
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State
            })
            .ToList();
        }

        public CityDto AddCity(City city)
        {
            _context.Cities.Add(city);
            _context.SaveChanges();

            return new CityDto
            {
                CityId = city.CityId,
                Name = city.Name,
                State = city.State
            };
        }

        public CityDto UpdateCity(City city)
        {
            _context.Cities.Update(city);
            _context.SaveChanges();

            var updatedCity = from c in _context.Cities
                              where c.CityId == city.CityId
                              select new CityDto
                              {
                                CityId = c.CityId,
                                Name = c.Name,
                                State = c.State,
                              };

            return updatedCity.First();
        }

    }
}