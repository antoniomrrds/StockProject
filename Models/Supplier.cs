using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StockProject.Models
{
    public class Supplier
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [DisplayName("Nome")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Endereço é obrigatório.")]
        [DisplayName("Endereço")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CNPJ é obrigatório.")]
        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "Formato de CNPJ inválido.")]
        public string CNPJ { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [RegularExpression(@"^\d{5}-\d{3}$", ErrorMessage = "Formato de CEP inválido.")]
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório.")]
        [DisplayName("Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public string QRCode { get; set; } = string.Empty;
    }
}