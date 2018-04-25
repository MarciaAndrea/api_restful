using System;
using System.Collections.Generic;
using System.Text;


using System.ComponentModel.DataAnnotations.Schema;

namespace Entidades.Models
{
    public class ServicoCondominio
    {
        [NotMapped]
        public int Id { get; set; }

        public int CondominioId { get; set; }
        public int ServicoId { get; set; }

        public virtual Condominio Condominio { get; set; }
        public virtual Servico Servico { get; set; }
    }
}
