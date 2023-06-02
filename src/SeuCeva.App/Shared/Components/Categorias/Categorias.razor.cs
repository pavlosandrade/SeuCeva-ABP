using SeuCeva.App.Data;

namespace SeuCeva.App.Shared.Components.Categorias
{
    public partial class Categorias
    {
        public List<CategoriaService> categoria { get; set; }

        public Categorias()
        {
            categoria = new List<CategoriaService>();
            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/cerveja.png",
                Nome = "Cervejas",
                Link = "/cervejas"
            });

            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/vodka.png",
                Nome = "Vodkas",
                Link = "/vodkas"
            });

            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/whisky.png",
                Nome = "Whiskys",
                Link = "/whiskys"
            });

            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/refri.png",
                Nome = "Refrigerantes",
                Link = "/refrigerantes"
            });

            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/suco.png",
                Nome = "Sucos",
                Link = "/sucos"
            });

            categoria.Add(new CategoriaService()
            {
                Ico = "/images/icos/vinho.png",
                Nome = "Vinhos",
                Link = "/vinhos"
            });
        }
    }
}
