using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Catering_Santa_Lucia.Data;
using Catering_Santa_Lucia.Models;

namespace Catering_Santa_Lucia.Controllers
{
    public class PlatosController : Controller
    {
        private readonly StaLuciaContext _context;

        public PlatosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: Platos
        public async Task<IActionResult> Index()
        {
            var staLuciaContext = _context.Plato.Include(p => p.TipoNavigation);
            return View(await staLuciaContext.ToListAsync());
        }
        // GET: Platos
        public async Task<IActionResult> IndexGeneral()
        {
            var staLuciaContext = _context.Plato.Include(p => p.TipoNavigation);
            return View(await staLuciaContext.ToListAsync());
        }

        // GET: Platos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .Include(p => p.TipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }

        // GET: Platos/Details/5
        public async Task<IActionResult> DetailsGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .Include(p => p.TipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }
        // GET: Platos/Create
        public IActionResult Create()
        {
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion");
            return View();
        }
        // GET: Platos/Create
        public IActionResult CreateGeneral()
        {
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion");
            return View();
        }

        // POST: Platos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Tipo")] Plato plato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Id", plato.Tipo);
            return View(plato);
        }
        // POST: Platos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGeneral([Bind("Id,Nombre,Tipo")] Plato plato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(plato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexGeneral));
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion", plato.Tipo);
            return View(plato);
        }

        // GET: Platos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato.FindAsync(id);
            if (plato == null)
            {
                return NotFound();
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion", plato.Tipo);
            return View(plato);
        }

        // GET: Platos/Edit/5
        public async Task<IActionResult> EditGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato.FindAsync(id);
            if (plato == null)
            {
                return NotFound();
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion", plato.Tipo);
            return View(plato);
        }
        // POST: Platos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Tipo")] Plato plato)
        {
            if (id != plato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatoExists(plato.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion", plato.Tipo);
            return View(plato);
        }
        // POST: Platos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditGeneral(int id, [Bind("Id,Nombre,Tipo")] Plato plato)
        {
            if (id != plato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(plato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatoExists(plato.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(IndexGeneral));
            }
            ViewData["Tipo"] = new SelectList(_context.TipoPlato, "Id", "Descripcion", plato.Tipo);
            return View(plato);
        }

        // GET: Platos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .Include(p => p.TipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }
        // GET: Platos/Delete/5
        public async Task<IActionResult> DeleteGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var plato = await _context.Plato
                .Include(p => p.TipoNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (plato == null)
            {
                return NotFound();
            }

            return View(plato);
        }

        // POST: Platos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var plato = await _context.Plato.FindAsync(id);
            _context.Plato.Remove(plato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // POST: Platos/Delete/5
        [HttpPost, ActionName("DeleteGeneral")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedGeneral(int id)
        {
            var plato = await _context.Plato.FindAsync(id);
            _context.Plato.Remove(plato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexGeneral));
        }

        private bool PlatoExists(int id)
        {
            return _context.Plato.Any(e => e.Id == id);
        }
    }
}
