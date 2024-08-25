using Microsoft.AspNetCore.Mvc;
using ProvaMVC.Models.Entity;
using ProvaMVC.Models.Repository;

namespace ProvaMVC.Controllers
{
    public class MatriculaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly MatriculaRepository _repository;

        public MatriculaController()
        {
            _repository = new MatriculaRepository();
        }

        [HttpGet]
        public IEnumerable<Matricula> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Matricula Get(Guid id)
        {
            return _repository.Selecionar(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Excluir(id);
        }
    }
}
