using SeuCeva.App.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeuCeva.App.Shared.Components.Produtos
{
    public partial class Produtos
    {
        public List<ProdutosService> produtos { get; set; }

        public Produtos()
        {
            produtos = new List<ProdutosService>();
            produtos.Add(new ProdutosService()
            {
                Img = "/images/produtos/duplo-malte-latao.webp",
                Nome =  "Bhrama Duplo Malte",
                Localizacao = "Carrefour Hipermercado Ribeirão Preto Via Norte",
                Preco = "R$ 4,09"
            });

            produtos.Add(new ProdutosService()
            {
                Img = "/images/produtos/heineken-500ml.webp",
                Nome = "Heineken Garrafa 330ml",
                Localizacao = "Savegnago Supermercados",
                Preco = "R$ 6,89"
            });

            produtos.Add(new ProdutosService()
            {
                Img = "/images/produtos/imperio-caixa.webp",
                Nome = "Império Lager Garrafa 275ml - Caixa",
                Localizacao = "Savegnago Supermercados",
                Preco = "R$ 169,90"
            });

            produtos.Add(new ProdutosService()
            {
                Img = "/images/produtos/subzero-lata.webp",
                Nome = "Antarctica Subzero 269ml Lata",
                Localizacao = "Savegnago Supermercados",
                Preco = "R$ 2,50"
            });

            produtos.Add(new ProdutosService()
            {
                Img = "/images/produtos/bhrama-lata.webp",
                Nome = "Bhrama Chopp Lata 350ml",
                Localizacao = "Carrefour Hipermercado Ribeirão Preto Via Norte",
                Preco = "R$ 3,39"
            });

        }
    }
}
