using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Senai.EfCore.Tarde.Domains
{
    /// <summary>
    /// Definir a classe produto
    /// </summary>
    public class Produto : BaseDomain
    {
        public string Nome { get; set; }
        public float Preco { get; set; }

        //Usada para receber o arquivo
        [NotMapped]
        [JsonIgnore]
        public IFormFile Imagem { get; set; }

        //url da imagem salva localmente
        public string UrlImagem { get; set; }

        //Relacionar com a tabela PedidoItem 1,N
        public List<PedidoItem> PedidosItens { get; set; }
    }
}
