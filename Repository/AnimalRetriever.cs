using animals_api_csharp.Contracts.V1;

namespace animals_api_csharp.Repository
{
    public interface IAnimalRetriever
    {
        Animal GetAnimalInfo(int animalId, string location);
    }

    public class AnimalRetriever : IAnimalRetriever
    {
        public Animal GetAnimalInfo(int animalId, string location)
        {
            return new ()
            {
                Name = "Panda",
                Location = location,
                Age = 2,
                Diet = Diet.HERBIVORES,
                Mood = "Happy"
            };
        }
    }
}