namespace Domain.Entities;

/// <summary>
/// Маркерный интерфейс сущности
/// </summary>
public interface IEntity 
{
    /// <summary>
    /// Уникальный идентификатор сущности
    /// </summary>
    public Guid Id { get; }
}