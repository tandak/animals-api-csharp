using animals_api_csharp.Mappers;
using animals_api_csharp.Models;
using animals_api_csharp.Services;
using Microsoft.AspNetCore.Mvc;

namespace animals_api_csharp.Controllers
{
    public class AnimalsController : ControllerBase //Abstract - A base class for an MVC controller without view support.
    {
        private readonly IAnimalsService _animalsService;
        private readonly IAnimalsResponseBuilder _animalsResponseBuilder;

        public AnimalsController(IAnimalsService animalsService, IAnimalsResponseBuilder animalsResponseBuilder)
        {
            _animalsService = animalsService;
            _animalsResponseBuilder = animalsResponseBuilder;
        }

        [HttpGet]
        [Route("/animal/info/v1/{animalId:int}")]
        public OkObjectResult GetAnimalInfo([FromQuery] AnimalInfoRequest request)
        {
            var animalInfo =  _animalsService.GetAnimalInformation(request.AnimalId, request.Location);

            var response = _animalsResponseBuilder.GetAnimalsResponse(animalInfo);

            return Ok(response);
        }
    }
}
