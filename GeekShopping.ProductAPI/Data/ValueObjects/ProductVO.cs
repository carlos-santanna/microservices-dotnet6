using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using GeekShopping.ProductAPI.Model;

namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO
    {
        //[MapTo(nameof(Product.Id))] //uma forma de gerar um mapeamento entre classes
        public long id { get; set; }        
        public string nome { get; set; }
        
        public decimal preco { get; set; }

        public string? descricao { get; set; }

        
        public string? nome_categoria { get; set; }
               
        public string? url_imagem { get; set; }
    }
}
