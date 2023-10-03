using System.ComponentModel.DataAnnotations;

namespace LogarRegistrar.Models
{
    public class User
    {
        [Key]
        public int pessoaId { get; set; }
        public string pessoaNome { get; set; }
        public string pessoaEmail { get; set; }
        public string pessoaUsuario { get; set; }
        public string pessoaSenha { get; set; }
        public string Token { get; set; }
        public string Role { get; set; }
        public bool pessoaTipo {  get; set; }

    }
}
