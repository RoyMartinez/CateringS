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
    public class MeserosController : Controller
    {
        private readonly StaLuciaContext _context;

        public MeserosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: Meseros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Mesero.ToListAsync());
        }

        // GET: Meseros/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesero = await _context.Mesero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mesero == null)
            {
                return NotFound();
            }

            return View(mesero);
        }

        // GET: Meseros/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Meseros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre")] Mesero mesero)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mesero);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mesero);
        }

        // GET: Meseros/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesero = await _context.Mesero.FindAsync(id);
            if (mesero == null)
            {
                return NotFound();
            }
            return View(mesero);
        }

        // POST: Meseros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre")] Mesero mesero)
        {
            if (id != mesero.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mesero);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MeseroExists(mesero.Id))
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
            return View(mesero);
        }

        // GET: Meseros/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mesero = await _context.Mesero
                .FirstOrDefaultAsync(m => m.Id == id);
            if (mesero == null)
            {
                return NotFound();
            }

            return View(mesero);
        }

        // POST: Meseros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mesero = await _context.Mesero.FindAsync(id);
            _context.Mesero.Remove(mesero);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MeseroExists(int id)
        {
            return _context.Mesero.Any(e => e.Id == id);
        }
    }
}
