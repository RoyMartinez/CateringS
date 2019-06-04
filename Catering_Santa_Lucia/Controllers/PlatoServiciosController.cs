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
    public class PlatoServiciosController : Controller
    {
        private readonly StaLuciaContext _context;

        public PlatoServiciosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: PlatoServicios
        public async Task<IActionResult> Index()
        {
            var staLuciaContext = _context.PlatoServicio.Include(p => p.MenuNavigation).Include(p => p.PlatoNavigation).Include(p => p.ServicioNavigation);
            return View(await staLuciaContext.ToListAsync());
        }

        // GET: PlatoServicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var platoServicio = await _context.PlatoServicio
                .Include(p => p.MenuNavigation)
                .Include(p => p.PlatoNavigation)
                .Include(p => p.ServicioNavigation)
                .FirstOrDefaultAsync(m => m.Plato == id);
            if (platoServicio == null)
            {
                return NotFound();
            }

            return View(platoServicio);
        }

        // GET: PlatoServicios/Create
        public IActionResult Create()
        {
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id");
            ViewData["Plato"] = new SelectList(_context.Plato, "Id", "Id");
            ViewData["Servicio"] = new SelectList(_context.Servicio, "Id", "Id");
            return View();
        }

        // POST: PlatoServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Plato,Servicio,Menu,Dia")] PlatoServicio platoServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(platoServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", platoServicio.Menu);
            ViewData["Plato"] = new SelectList(_context.Plato, "Id", "Id", platoServicio.Plato);
            ViewData["Servicio"] = new SelectList(_context.Servicio, "Id", "Id", platoServicio.Servicio);
            return View(platoServicio);
        }

        // GET: PlatoServicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var platoServicio = await _context.PlatoServicio.FindAsync(id);
            if (platoServicio == null)
            {
                return NotFound();
            }
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", platoServicio.Menu);
            ViewData["Plato"] = new SelectList(_context.Plato, "Id", "Id", platoServicio.Plato);
            ViewData["Servicio"] = new SelectList(_context.Servicio, "Id", "Id", platoServicio.Servicio);
            return View(platoServicio);
        }

        // POST: PlatoServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Plato,Servicio,Menu,Dia")] PlatoServicio platoServicio)
        {
            if (id != platoServicio.Plato)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(platoServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlatoServicioExists(platoServicio.Plato))
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
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", platoServicio.Menu);
            ViewData["Plato"] = new SelectList(_context.Plato, "Id", "Id", platoServicio.Plato);
            ViewData["Servicio"] = new SelectList(_context.Servicio, "Id", "Id", platoServicio.Servicio);
            return View(platoServicio);
        }

        // GET: PlatoServicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var platoServicio = await _context.PlatoServicio
                .Include(p => p.MenuNavigation)
                .Include(p => p.PlatoNavigation)
                .Include(p => p.ServicioNavigation)
                .FirstOrDefaultAsync(m => m.Plato == id);
            if (platoServicio == null)
            {
                return NotFound();
            }

            return View(platoServicio);
        }

        // POST: PlatoServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var platoServicio = await _context.PlatoServicio.FindAsync(id);
            _context.PlatoServicio.Remove(platoServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlatoServicioExists(int id)
        {
            return _context.PlatoServicio.Any(e => e.Plato == id);
        }
    }
}
