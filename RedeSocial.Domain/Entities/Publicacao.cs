using RedeSocial.Domain.Enum;

namespace RedeSocial.Domain.Entities
{
    public class Publicacao : Entity
    {
        public int Id { get; set; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { get; set; }
        public VisibilidadeEnum Visibilidade { get; set; }
        public int UsuarioId { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<Curtida> Curtidas { get; set; }
        public bool FlAtivo { get; set; }
    }
}
