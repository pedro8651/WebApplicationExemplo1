namespace WebApplicationExemplo1.Models
{
    public class Turma{
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public string Turno { get; set; }
        public string Nome { get; set; }

        public ICollection<Aluno>? alunos { get; set; }

    }
}
