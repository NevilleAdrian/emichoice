using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmiChoiceTravels.Repository
{
    public class LocationRepository
    {
        private string BaseUrl => "https://api.skypicker.com/locations";
        private readonly IHttpClientFactory _client;
        public LocationRepository(IHttpClientFactory clientFactory)
        {
            _client = clientFactory;
        }
        
    }
}
