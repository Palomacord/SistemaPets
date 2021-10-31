using System.Collections.Generic;

namespace SistemaPets.Models
{
    public class Tutor
    {
        public int TutorId { get; set; }
        public string Nome{ get; set; }

        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public virtual ICollection<Pet>  Pets { get; set; }
    }
}