using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebCRUD.Data;
using WebCRUD.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebCRUD.Controllers
{
    [Authorize]
    public class EmpleadasController : Controller
    {
        private readonly AppDbContext _context;

        public EmpleadasController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Empleadas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Empleadas.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var empleada = await _context.Empleadas.FirstOrDefaultAsync(m => m.Id == id);
            if (empleada == null) return NotFound();

            return View(empleada);
        }

        // GET: Empleadas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Empleadas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Empleada empleada)
        {
            if (ModelState.IsValid)
            {
                _context.Add(empleada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleada);
        }

        // GET: Empleadas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var empleada = await _context.Empleadas.FindAsync(id);
            if (empleada == null) return NotFound();
            return View(empleada);
        }

        // POST: Empleadas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Empleada empleada)
        {
            if (id != empleada.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(empleada);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(empleada);
        }

        // GET: Empleadas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var empleada = await _context.Empleadas.FirstOrDefaultAsync(m => m.Id == id);
            if (empleada == null) return NotFound();
            return View(empleada);
        }

        // POST: Empleadas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var empleada = await _context.Empleadas.FindAsync(id);
            _context.Empleadas.Remove(empleada);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
