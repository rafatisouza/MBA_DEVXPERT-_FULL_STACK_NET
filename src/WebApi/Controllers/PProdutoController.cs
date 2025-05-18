using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class PProdutoController : Controller
    {
        private readonly AppDbContext _context;
        public PProdutoController(AppDbContext context) 
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Produto>>> GetProdutos()
        {
            return await _context.Produtos.ToListAsync();
        }
        // GET: PProdutoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PProdutoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PProdutoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PProdutoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PProdutoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PProdutoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PProdutoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PProdutoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
