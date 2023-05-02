using UDPBroadcastAPI.Models;

namespace UDPBroadcastAPI.Repo
{
    public class TemperatureRepository
    {
        public List<Temperature> _items;

        public TemperatureRepository()
        {
            _items = new List<Temperature>();
        }

        public List<Temperature> GetAll()
        {
            return _items;
        }

        public void Add(Temperature temperature)
        {
            _items.Add(temperature);
        }
    }
}
