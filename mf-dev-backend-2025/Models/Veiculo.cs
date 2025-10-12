using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veiculos")]
    public class Veiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Placa é obrigatório.")]
        public string Placa { get; set; }

        [Display(Name = "Ano de Fabricação")]
        [Required(ErrorMessage = "O campo Ano de Fabricação é obrigatório.")]
        public int AnoFabricacao { get; set; }

        [Display(Name = "Ano do Modelo")]
        [Required(ErrorMessage = "O campo Ano do Modelo é obrigatório.")]
        public int AnoModelo { get; set; }
    }
}
