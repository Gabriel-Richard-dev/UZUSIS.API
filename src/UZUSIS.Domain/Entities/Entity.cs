using UZUSIS.Domain.Contracts;

namespace UZUSIS.Domain.Entities;

public abstract class Entity : IEntity
{
    public long Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }
}