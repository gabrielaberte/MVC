using Microsoft.AspNetCore.Mvc;
using ProvaMVC.Models.Entity;
using ProvaMVC.Models.Repository;

namespace ProvaMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly AlunoRepository _repository;

        public AlunoController()
        {
            _repository = new AlunoRepository();
        }

        [HttpGet]
        public IEnumerable<Aluno> Get()
        {
            return _repository.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Aluno Get(Guid id)
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
