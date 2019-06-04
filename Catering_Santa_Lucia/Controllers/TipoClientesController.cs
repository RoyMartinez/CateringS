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
    public class TipoClientesController : Controller
    {
        private readonly StaLuciaContext _context;

        public TipoClientesController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: TipoClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoCliente.ToListAsync());
        }

        // GET: TipoClientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCliente = await _context.TipoCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoCliente == null)
            {
                return NotFound();
            }

            return View(tipoCliente);
        }

        // GET: TipoClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoClientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] TipoCliente tipoCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoCliente);
        }

        // GET: TipoClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCliente = await _context.TipoCliente.FindAsync(id);
            if (tipoCliente == null)
            {
                return NotFound();
            }
            return View(tipoCliente);
        }

        // POST: TipoClientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] TipoCliente tipoCliente)
        {
            if (id != tipoCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoClienteExists(tipoCliente.Id))
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
            return View(tipoCliente);
        }

        // GET: TipoClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoCliente = await _context.TipoCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoCliente == null)
            {
                return NotFound();
            }

            return View(tipoCliente);
        }

        // POST: TipoClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoCliente = await _context.TipoCliente.FindAsync(id);
            _context.TipoCliente.Remove(tipoCliente);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoClienteExists(int id)
        {
            return _context.TipoCliente.Any(e => e.Id == id);
        }
    }
}
