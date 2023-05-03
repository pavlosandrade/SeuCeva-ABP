using SeuCeva.Empresas;
using SeuCeva.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace SeuCeva.ProdutosEmpresas
{
    public class ProdutosEmpresa : FullAuditedAggregateRoot<Guid>
    {
        [ForeignKey(nameof(Empresa))]
        public Guid EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        [ForeignKey(nameof(Produto))]
        public Guid ProdutoId { get; set; }
        public Produto Produto { get; set; }
    }
}
