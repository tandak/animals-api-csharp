namespace animals_api_csharp.Contracts.V1
{
    public class Animal
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public int Age { get; set; }
        public string Mood { get; set; }
        public Type Type { get; set; }
        public string Habitat { get; set; }
        public Diet Diet { get; set; }
    }

    public enum Type
    {
        MAMMAL,
        BIRD,
        FISH,
        AMPHIBIAN,
        REPTILES,
        INVERTEBRATES
    }

    public enum Diet
    {
        CARNIVORES,
        HERBIVORES,
        OMINIVORES
    }
}