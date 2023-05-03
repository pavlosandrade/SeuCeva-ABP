using SeuCeva.Produtos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace SeuCeva.Categorias
{
    public class Categoria : FullAuditedAggregateRoot<Guid>
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
    }
}
