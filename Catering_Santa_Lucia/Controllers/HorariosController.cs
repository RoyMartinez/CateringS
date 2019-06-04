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
    public class HorariosController : Controller
    {
        private readonly StaLuciaContext _context;

        public HorariosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: Horarios
        public async Task<IActionResult> Index()
        {
            var staLuciaContext = _context.Horario.Include(h => h.MeseroNavigation).Include(h => h.PedidoNavigation);
            return View(await staLuciaContext.ToListAsync());
        }

        // GET: Horarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario
                .Include(h => h.MeseroNavigation)
                .Include(h => h.PedidoNavigation)
                .FirstOrDefaultAsync(m => m.Pedido == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // GET: Horarios/Create
        public IActionResult Create()
        {
            ViewData["Mesero"] = new SelectList(_context.Mesero, "Id", "Id");
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id");
            return View();
        }

        // POST: Horarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pedido,Mesero,Cantidad")] Horario horario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(horario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Mesero"] = new SelectList(_context.Mesero, "Id", "Id", horario.Mesero);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", horario.Pedido);
            return View(horario);
        }

        // GET: Horarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario.FindAsync(id);
            if (horario == null)
            {
                return NotFound();
            }
            ViewData["Mesero"] = new SelectList(_context.Mesero, "Id", "Id", horario.Mesero);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", horario.Pedido);
            return View(horario);
        }

        // POST: Horarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pedido,Mesero,Cantidad")] Horario horario)
        {
            if (id != horario.Pedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(horario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HorarioExists(horario.Pedido))
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
            ViewData["Mesero"] = new SelectList(_context.Mesero, "Id", "Id", horario.Mesero);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", horario.Pedido);
            return View(horario);
        }

        // GET: Horarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var horario = await _context.Horario
                .Include(h => h.MeseroNavigation)
                .Include(h => h.PedidoNavigation)
                .FirstOrDefaultAsync(m => m.Pedido == id);
            if (horario == null)
            {
                return NotFound();
            }

            return View(horario);
        }

        // POST: Horarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var horario = await _context.Horario.FindAsync(id);
            _context.Horario.Remove(horario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HorarioExists(int id)
        {
            return _context.Horario.Any(e => e.Pedido == id);
        }
    }
}
