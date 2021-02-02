using animals_api_csharp.Contracts.V1;

namespace animals_api_csharp.Mappers
{
    public interface IAnimalsResponseBuilder
    {
        AnimalsResponse? GetAnimalsResponse(Animal animal);
    }

    public class AnimalsResponseBuilder : IAnimalsResponseBuilder
    {
        public AnimalsResponse? GetAnimalsResponse(Animal animal)
        {
            return new()
            {
                Name = animal.Name,
                Mood = animal.Mood
            };
        }
    }
}