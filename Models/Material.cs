using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockProject.Models
{
    public class Material
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Fornecedor é obrigatório")]
        [ForeignKey("Supplier")]
        [DisplayName("Fornecedor")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "O campo Código é obrigatório")]
        [StringLength(20, ErrorMessage = "O código deve ter no máximo 20 caracteres")]
        [DisplayName("Código")]
        public string Code { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(100, ErrorMessage = "O nome deve ter no máximo 100 caracteres")]
        [DisplayName("Nome")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Descrição é obrigatório")]
        [StringLength(500, ErrorMessage = "A descrição deve ter no máximo 500 caracteres")]
        [DisplayName("Descrição")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Código Fiscal é obrigatório")]
        [StringLength(14, ErrorMessage = "O código fiscal deve ter no máximo 14 caracteres")]
        [DisplayName("Código Fiscal")]
        public string FiscalCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Espécie é obrigatório")]
        [StringLength(50, ErrorMessage = "A espécie deve ter no máximo 50 caracteres")]
        [DisplayName("Espécie")]
        public string Specie { get; set; } = string.Empty;

        [Required(ErrorMessage = "O campo Data de Criação é obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime CreatedAt { get; private set; } = DateTime.Now;

        [Required(ErrorMessage = "O campo Criado Por é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Criado por deve ter no máximo 50 caracteres")]
        [DisplayName("Criado Por")]
        public string CreatedBy { get; set; } = string.Empty;

        [DisplayName("Data de Atualização")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? UpdatedAt { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "O campo Atualizado Por é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo Atualizado por deve ter no máximo 50 caracteres")]
        [DisplayName("Atualizado Por")]
        public string UpdatedBy { get; set; } = string.Empty;

        public Supplier? Supplier { get; set; }
    }
}