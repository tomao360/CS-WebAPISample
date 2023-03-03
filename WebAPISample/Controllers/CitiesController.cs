using Microsoft.AspNetCore.Mvc;

namespace WebAPISample.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController:ControllerBase
    {
        [HttpGet("citieslist")]
        public JsonResult GetList()
        {
            List<City> list = new List<City>();
            list.Add(new City() { Id = 1, Name = "Ramat Gan" });
            list.Add(new City() { Id = 2, Name = "Tel Aviv" });
            list.Add(new City() { Id = 3, Name = "Hadera" });
            list.Add(new City() { Id = 4, Name = "Jerusalem" });

            return new JsonResult(list);

            /*
            return new JsonResult(new List<object>
            {
                new {Id = 10, Name = "Ramat Gan"},
                new {Id = 11, Name = "Tel Aviv"},
                new {Id = 12, Name = "Hadera"},
                new {Id = 13, Name = "Jerusalem"}
            });
            */
        }


        [HttpGet("getonecity/{id}")]
        public JsonResult GetCity(int id)
        {
            List<City> list = new List<City>();
            list.Add(new City() { Id = 1, Name = "Ramat Gan" });
            list.Add(new City() { Id = 2, Name = "Tel Aviv" });
            list.Add(new City() { Id = 3, Name = "Hadera" });
            list.Add(new City() { Id = 4, Name = "Jerusalem" });

            var ret = list.Find(x => x.Id == id);

            return new JsonResult(ret);
        }


        [HttpPost("savecity")]
        public JsonResult SaveCityData(int id, string name)
        {
            return new JsonResult("OK");
        }
    }
}
