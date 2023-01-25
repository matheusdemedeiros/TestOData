using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace TestOData.Models
{
    public class Escola
    {
        public Escola()
        {
            Alunos = new Collection<Aluno>();
        }

        public int EscolaId { get; set; }

        [Required]
        [MaxLength(80)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(2)]
        public string Estado { get; set; }

        [Required]
        [MaxLength(80)]
        public string Cidade { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
    }   
}
