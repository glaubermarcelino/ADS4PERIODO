namespace ReclameJa.Models
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Senha { get; set; }
        public string NomeUsuario { get; set; }
        public bool Ativo { get; set; }
        public virtual Cidadao Cidadao { get; set; }
        public virtual Funcionario Funcionario { get; set; }
    }
}
