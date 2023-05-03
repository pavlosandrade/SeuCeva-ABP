using SeuCeva.ProdutosEmpresas;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Identity;

namespace SeuCeva.Empresas
{
    public class Empresa : FullAuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Localizacao { get; set; }
        [ForeignKey(nameof(IdentityUser))]
        public Guid UsuarioId { get; set; }
        public IdentityUser IdentityUser { get; set; }
        public ICollection<ProdutosEmpresa> ListaProdutos { get; set; }
    }
}
