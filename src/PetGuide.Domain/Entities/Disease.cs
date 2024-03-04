namespace PetGuide.Domain.Entities;
public class Disease : Entity
{
    public string? Name { get; set; }
    public IList<Species>? AffectedSpecies { get; set; }

}
