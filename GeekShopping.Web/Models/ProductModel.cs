namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long id { get; set; }
        public string nome { get; set; }

        public decimal preco { get; set; }

        public string? descricao { get; set; }


        public string? nome_categoria { get; set; }

        public string? url_imagem { get; set; }
    }
}
