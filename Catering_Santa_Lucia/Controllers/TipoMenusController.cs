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
    public class TipoMenusController : Controller
    {
        private readonly StaLuciaContext _context;

        public TipoMenusController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: TipoMenus
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoMenu.ToListAsync());
        }

        // GET: TipoMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoMenu = await _context.TipoMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoMenu == null)
            {
                return NotFound();
            }

            return View(tipoMenu);
        }

        // GET: TipoMenus/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] TipoMenu tipoMenu)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoMenu);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoMenu);
        }

        // GET: TipoMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoMenu = await _context.TipoMenu.FindAsync(id);
            if (tipoMenu == null)
            {
                return NotFound();
            }
            return View(tipoMenu);
        }

        // POST: TipoMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] TipoMenu tipoMenu)
        {
            if (id != tipoMenu.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoMenu);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoMenuExists(tipoMenu.Id))
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
            return View(tipoMenu);
        }

        // GET: TipoMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoMenu = await _context.TipoMenu
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoMenu == null)
            {
                return NotFound();
            }

            return View(tipoMenu);
        }

        // POST: TipoMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoMenu = await _context.TipoMenu.FindAsync(id);
            _context.TipoMenu.Remove(tipoMenu);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoMenuExists(int id)
        {
            return _context.TipoMenu.Any(e => e.Id == id);
        }
    }
}
