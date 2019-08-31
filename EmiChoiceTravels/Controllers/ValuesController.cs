using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EmiChoiceTravels.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmiChoiceTravels.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private string BaseUrl => "https://api.skypicker.com/locations";
        private readonly IHttpClientFactory _client;
        public ValuesController(IHttpClientFactory clientFactory)
        {
            _client = clientFactory;
        }
        // GET api/values
        [HttpGet]
        [Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2"};
        }

        // GET api/values/5
        //locations?type=id&id=ZW&locale=en-US&active_only=true
        [HttpGet("location")]
        //public async Task<ActionResult> Get(string type, string term, int limit, string source_popularity, string fallback_popularity)
        public async Task<ActionResult> Get([FromQuery] LocationHashTag model)
        {
            //set the message
            var request = new HttpRequestMessage(HttpMethod.Get, BaseUrl);
            request.Headers.Add("Accept", "application/json");
            //string extra = $"locations?type={type}&term={term}&limit={limit}&source_popularity={source_popularity}&fallback_popularity={fallback_popularity}";
            HttpContent content = new StringContent(model.ToJson());
            request.Content = content;
            var httpRequest = _client.CreateClient();
            var response = await httpRequest.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                return Ok(result);
            }
            return BadRequest();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
