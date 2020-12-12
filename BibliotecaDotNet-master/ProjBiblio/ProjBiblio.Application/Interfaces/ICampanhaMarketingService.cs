using System.Collections.Generic;
using ProjBiblio.Application.DTOs;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.ViewModels;

namespace ProjBiblio.Application.Interfaces {
    public interface ICampanhaMarketingService {
        IList<CampanhaMarketingSelectListDto> ListagemCampanhaMarketingPorLivro (int idLivro);

        CampanhaMarketingListViewModel  Get ();

        CampanhaMarketingViewModel Get (int id);

        CampanhaMarketingViewModel Post (CampanhaMarketingInputModel autor);

        CampanhaMarketingViewModel Put (int id, CampanhaMarketingInputModel autor);

        CampanhaMarketingViewModel Delete (int id);
    }
}