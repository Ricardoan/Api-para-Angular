using System.ComponentModel.DataAnnotations;

namespace ApiRinunci.Models
{
    public class Pessoa
    {
         
        [Key]
        public int pessoaId { get; set; }
        [Required]
        [StringLength(255)]
        public string nomePessoa { get; set; }

        [StringLength(11)]
        public string cpf { get; set; }

        [Required]
        public DateTime dataPessoa { get; set; }
    
    }
}
