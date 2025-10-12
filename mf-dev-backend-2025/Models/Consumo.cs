using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Consumos")]
    public class Consumo
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Descrição é obrigatório")]
        public string descricao { get; set; }

        [Required(ErrorMessage = "Campo Data é obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Campo Valor é obrigatório")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Campo km é obrigatório")]
        public int km { get; set; }

        [Display(Name = "Tipo de Combustível")]
        public TipoCombustivel tipoCombustivel { get; set; }

        [Display(Name = "Veículo")]
        public int VeiculoId { get; set; }

        [ForeignKey("VeiculoId")]
        [Display(Name = "Veículo")]
        public Veiculo veiculo { get; set; }
    }

    public enum TipoCombustivel
    {
        Gasolina,
        Etanol,
        Diesel
    }
}
