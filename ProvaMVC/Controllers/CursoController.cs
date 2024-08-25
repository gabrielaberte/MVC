using Microsoft.AspNetCore.Mvc;
using ProvaMVC.Models.Entity;
using ProvaMVC.Models.Repository;

namespace ProvaMVC.Controllers
{
    public class CursoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly CursoRepository _repository;

        public CursoController()
        {
            _repository = new CursoRepository();
        }

        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Curso Get(Guid id)
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
