using animals_api_csharp.Contracts.V1;
using animals_api_csharp.Repository;

namespace animals_api_csharp.Services
{
    public interface IAnimalsService
    {
        Animal GetAnimalInformation(int animalId, string location);
    }

    public class AnimalsService : IAnimalsService
    {
        private readonly IAnimalRetriever _animalRetriever;

        public AnimalsService(IAnimalRetriever animalRetriever)
        {
            _animalRetriever = animalRetriever;
        }

        public Animal GetAnimalInformation(int animalId, string location)
        {
            return _animalRetriever.GetAnimalInfo(animalId, location);
        }
    }
}