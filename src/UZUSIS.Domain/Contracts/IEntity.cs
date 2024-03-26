namespace UZUSIS.Domain.Contracts;

public interface IEntity
{
    public long Id { get; set; }
    public DateTime DataCriacao { get; set; }
    public DateTime DataAtualizacao { get; set; }

    List<string?>? Validate();

}