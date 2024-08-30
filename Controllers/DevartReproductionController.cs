using System;
using System.Collections.Generic;
using System.Linq;
using DevartReproduction.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.OData.Query;

namespace DevartReproduction.Controllers
{
    //[ApiController]
    //[Route("DevartReproduction")]
    public class DevartReproductionController : Controller
    {
        private readonly ILogger<DevartReproductionController> _logger;

        private readonly CarsContext _carsContext;

        public DevartReproductionController(ILogger<DevartReproductionController> logger, CarsContext carsContext)
        {
            _logger = logger;
            _carsContext = carsContext;
        }

        [HttpGet]
        [EnableQuery()]
        [Route("DevartReproduction")]
        public IQueryable<CarDto> Get()
        {
            var result = from car in _carsContext.Cars
                         select new CarDto()
                         {
                             ID = car.ID,
                             Brand = car.NAME,
                             HasMoreThenOneModel = (
                                (from model in _carsContext.Models
                                 where model.CAR_ID == car.ID
                                 select model)
                                 .Count() > 1
                             ),
                             HasModels = (
                                (from model in _carsContext.Models
                                 where model.CAR_ID == car.ID
                                 select model)
                                 .Any()
                             ),
                             IsLuxery = car.LUXERYBRAND == "J",
                             isCar = true
                         };

            return result;
        }
    }
}
