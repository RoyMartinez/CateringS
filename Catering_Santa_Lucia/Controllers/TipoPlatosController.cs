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
    public class TipoPlatosController : Controller
    {
        private readonly StaLuciaContext _context;

        public TipoPlatosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: TipoPlatos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPlato.ToListAsync());
        }

        // GET: TipoPlatos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPlato = await _context.TipoPlato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPlato == null)
            {
                return NotFound();
            }

            return View(tipoPlato);
        }

        // GET: TipoPlatos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoPlatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] TipoPlato tipoPlato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPlato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPlato);
        }

        // GET: TipoPlatos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPlato = await _context.TipoPlato.FindAsync(id);
            if (tipoPlato == null)
            {
                return NotFound();
            }
            return View(tipoPlato);
        }

        // POST: TipoPlatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] TipoPlato tipoPlato)
        {
            if (id != tipoPlato.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPlato);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPlatoExists(tipoPlato.Id))
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
            return View(tipoPlato);
        }

        // GET: TipoPlatos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPlato = await _context.TipoPlato
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPlato == null)
            {
                return NotFound();
            }

            return View(tipoPlato);
        }

        // POST: TipoPlatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPlato = await _context.TipoPlato.FindAsync(id);
            _context.TipoPlato.Remove(tipoPlato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPlatoExists(int id)
        {
            return _context.TipoPlato.Any(e => e.Id == id);
        }
    }
}
