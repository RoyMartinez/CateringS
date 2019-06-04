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
    public class TipoPedidosController : Controller
    {
        private readonly StaLuciaContext _context;

        public TipoPedidosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: TipoPedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoPedido.ToListAsync());
        }

        // GET: TipoPedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPedido = await _context.TipoPedido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPedido == null)
            {
                return NotFound();
            }

            return View(tipoPedido);
        }

        // GET: TipoPedidos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoPedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] TipoPedido tipoPedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoPedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoPedido);
        }

        // GET: TipoPedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPedido = await _context.TipoPedido.FindAsync(id);
            if (tipoPedido == null)
            {
                return NotFound();
            }
            return View(tipoPedido);
        }

        // POST: TipoPedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] TipoPedido tipoPedido)
        {
            if (id != tipoPedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoPedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoPedidoExists(tipoPedido.Id))
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
            return View(tipoPedido);
        }

        // GET: TipoPedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoPedido = await _context.TipoPedido
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoPedido == null)
            {
                return NotFound();
            }

            return View(tipoPedido);
        }

        // POST: TipoPedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoPedido = await _context.TipoPedido.FindAsync(id);
            _context.TipoPedido.Remove(tipoPedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoPedidoExists(int id)
        {
            return _context.TipoPedido.Any(e => e.Id == id);
        }
    }
}
