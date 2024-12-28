namespace RedeSocial.Domain.Entities
{
    public class Comentario : Entity
    {
        public int Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public string Texto { get; set; }
        public int UsuarioId { get; set; }
        public int PublicacaoId { get; set; }
        public bool FlAtivo { get; set; }
    }
}
