namespace ApiRinunci.Models;

using System.ComponentModel.DataAnnotations;

    public class cidade
    {
    [Key]
    public int cidadeId { get; set; }
    [Required]
    [StringLength(255)]
    public string nomecidade { get; set; }
}

