using System.ComponentModel.DataAnnotations;

namespace Projeto_API_Banco_Carrefour.Models
{
    public class EmpodeiramentoFEM
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao{ get; set; }
        public string Link{ get; set; }
    }
}

