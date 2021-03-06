using System.Collections.Generic;

namespace ProjBiblio.Domain.Entities
{
    public class Livro
    {
        public int LivroID { get; set; }

        public string Titulo { get; set; }

        public int? Quantidade { get; set; }

        public string Foto { get; set; }

        public int? Ano { get; set; }

        public int? Edicao { get; set; }

        public int? Paginas { get; set; }

        public string Editora { get; set; }

        public virtual Genero genero { get; set; }

        public ICollection<LivroAutor> LivAutor { get; set; }

        public ICollection<LivroEmprestimo> LivEmprestimo { get; set; }

        public ICollection<CampanhaMarketingLivro> LivMarketing { get; set; }

        public Livro()
        {
            LivAutor = new List<LivroAutor>();
            LivEmprestimo = new List<LivroEmprestimo>();
            LivMarketing = new List<CampanhaMarketingLivro>();
        }
    }
}