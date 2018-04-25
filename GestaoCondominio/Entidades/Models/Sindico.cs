using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.Models
{
    public class Sindico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
<<<<<<< HEAD
        public virtual Condominio Condominio { get; set; }
        public virtual Morador Morador { get; set; }
=======
        public virtual Condominio Condominios { get; set; }
        public virtual Morador Moradores { get; set; }
>>>>>>> 53f300b6990a655ad716177bab8ed3a267b8721d
    }
}
