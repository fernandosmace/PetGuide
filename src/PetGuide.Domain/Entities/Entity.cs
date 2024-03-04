using Flunt.Notifications;

namespace PetGuide.Domain.Entities;
public abstract class Entity : Notifiable
{
    public Guid ID { get; set; }
}