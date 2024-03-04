using PetGuide.Domain.Enums;

namespace PetGuide.Domain.Entities;
public class Species : Entity
{
    public string? Name { get; set; }
    public ESpeciesGroup? Group { get; set; }
}
