using System;

namespace ProjBiblio.Application.ViewModels {
    public class CarrinhoViewModel {
        public long Id { get; set; }
        public int? EmprestimoID { get; set; }

        public string SessionUserID { get; set; }

        public int LivroID { get; set; }

        public string NomeLivro { get; set; }

        public int Quantidade { get; set; }
    }
}