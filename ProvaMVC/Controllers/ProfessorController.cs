using Microsoft.AspNetCore.Mvc;
using ProvaMVC.Models.Entity;
using ProvaMVC.Models.Repository;

namespace ProvaMVC.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly ProfessorRepository _repository;

        public ProfessorController()
        {
            _repository = new ProfessorRepository();
        }

        [HttpGet]
        public IEnumerable<Professor> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Professor Get(Guid id)
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
