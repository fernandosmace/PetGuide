using Flunt.Validations;
using PetGuide.Domain.Enums;

namespace PetGuide.Domain.Entities
{
    public class Pet : Entity
    {
        public string? Name { get; set; }
        public Species? Species { get; set; }
        public DateTime? Birthdate { get; set; }
        public double Weight { get; set; }
        public EPetSize? Size { get; set; }
        public EFurType? FurType { get; set; }
        public EFurColor? FurColor { get; set; }
        public decimal Price { get; set; }

        public Pet(string? name, Species? species, DateTime? birthdate, double weight, EPetSize? size, EFurType? furType, EFurColor? furColor)
        {
            Name = name;
            Species = species;
            Birthdate = birthdate;
            Weight = weight;
            Size = size;
            FurType = furType;
            FurColor = furColor;

            AddNotifications(
                new Contract()
                .Requires()
                .IsNotNullOrEmpty(Name, nameof(Name), "O nome não pode ser em branco ou nulo.")
                .IsNotNull(Species, nameof(Species), "Espécie não pode ser nulo.")
                .IsNotNull(Birthdate, nameof(Birthdate), "Data de nascimento não pode ser nulo.")
                .IsGreaterThan(Weight, 0, nameof(Weight), "O peso deve ser maior que zero.")
                .IsNotNull(Size, nameof(Size), "Tamanho não pode ser nulo.")
                .IsNotNull(FurType, nameof(FurType), "Pelagem não pode ser nulo.")
                .IsNotNull(FurColor, nameof(FurColor), "Cor da pelagem não pode ser nulo."));
        }
    }
}