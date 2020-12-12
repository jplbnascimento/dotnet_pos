using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteBibliotecaMVC.Models;

namespace SiteBibliotecaMVC.ViewComponents {
    public class ListagemLivrosViewComponent : ViewComponent {
        private readonly HttpClient _httpClient;

        public ListagemLivrosViewComponent (HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync () {
            var produtos = await GetListagemLivrosAsync ();
            return View (produtos);
        }

        private async Task<IEnumerable<LivroViewModel>> GetListagemLivrosAsync () {
            var url = $"/Livros";
            var resposta = await _httpClient.GetFromJsonAsync<LivroListViewModel> (url);

            return resposta.Livros;
        }
    }
}