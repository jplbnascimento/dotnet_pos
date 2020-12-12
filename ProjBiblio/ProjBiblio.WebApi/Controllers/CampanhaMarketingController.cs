using Microsoft.AspNetCore.Mvc;
using ProjBiblio.Application.DTOs;
using ProjBiblio.Application.InputModels;
using ProjBiblio.Application.Interfaces;
using ProjBiblio.Application.ViewModels;
using System.Collections.Generic;

namespace ProjBiblio.WebApi.Controllers {
    [ApiController]
    [Route ("[controller]")]

    public class CampanhaMarketingController : ControllerBase {
        private ICampanhaMarketingService _campanhaMktService;

        public CampanhaMarketingController (ICampanhaMarketingService campanhaMktService) {
            this._campanhaMktService = campanhaMktService;
        }

        [HttpGet]
        public CampanhaMarketingListViewModel Get () {
            return _campanhaMktService.Get ();
        }

        [HttpGet ("{id}", Name = "GetCampanhaMarketingDetails")]
        public ActionResult<CampanhaMarketingViewModel> Get (int id) {
            var result = _campanhaMktService.Get (id);

            if (result == null)
                return NotFound ();

            return result;
        }

        [HttpPost]
        public ActionResult Post ([FromBody] CampanhaMarketingInputModel campanhaMarketing) {
            var result = _campanhaMktService.Post (campanhaMarketing);

            return new CreatedAtRouteResult ("GetCampanhaMarketingDetails",
                new { id = result.MarketingID }, result);
        }

        [HttpPut ("{id}")]
        public ActionResult Put (int id, [FromBody] CampanhaMarketingInputModel campanhaMarketing) {
            if (id != campanhaMarketing.MarketingID) {
                return BadRequest ();
            }

            var result = _campanhaMktService.Put (id, campanhaMarketing);

            return new CreatedAtRouteResult ("GetCampanhaMarketingDetails",
                new { id = result.MarketingID }, result);
        }

        [HttpDelete ("{id}")]
        public ActionResult<CampanhaMarketingViewModel> Delete (int id) {
            var result = _campanhaMktService.Delete (id);

            if (result == null) {
                return NotFound ();
            }

            return result;
        }

        [HttpGet ("listcampanhamaketinglivro/{id}")]
        public IList<CampanhaMarketingSelectListDto> ListagemCampanhaMarketingPorLivro (int id) {
            var result = _campanhaMktService.ListagemCampanhaMarketingPorLivro (id);

            return result;
        }
    }
}