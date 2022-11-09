using GeekShopping.ProductAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.ProductAPI.Model
{
    [Table("Product")] //anotação para dizer o nome da tabela no banco
    public class Product:BaseEntity
    {
        [Column("Name")] //nome da coluna para fazer o bind com o database
        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Column("Price")]
        [Required]
        [Range(1,10000)]        
        public decimal Price { get; set; }

        [Column("Description")]
        [StringLength(500)]
        public string? Description { get; set; }

        [Column("CategoryName")]
        [StringLength(50)]
        public string? CategoryName { get; set; }

        [Column("ImageUrl")]
        [StringLength(300)]
        public string? ImageUrl { get; set; }

    }
}
