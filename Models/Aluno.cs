namespace WebApplicationExemplo1.Models
{
    public class Aluno{
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Data {  get; set; }
        public string Cpf { get; set; }
        public Turma turma { get; set; }
        public string Responsavel { get; set; }
    }
}
