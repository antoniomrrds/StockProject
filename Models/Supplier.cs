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
        [RegularExpression(@"^\d{14}$", ErrorMessage = "O CNPJ deve conter exatamente 14 dígitos.")]
        public string CNPJ { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [RegularExpression(@"^\d{8}$", ErrorMessage = "O CEP deve conter exatamente 8 dígitos.")]
        public string CEP { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Data de Cadastro é obrigatório.")]
        [DisplayName("Data de Cadastro")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedAt { get; set; }

        public string QRCode { get; set; } = string.Empty;

        public string GenerateQRCode()
        {
            return $"{CNPJ}-{CEP}/CAD.{CreatedAt:dd/MM/yyyy}";
        }
    }
}