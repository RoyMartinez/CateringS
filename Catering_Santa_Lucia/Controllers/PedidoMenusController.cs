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
    public class PedidoMenusController : Controller
    {
        private readonly StaLuciaContext _context;

        public PedidoMenusController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: PedidoMenus
        public async Task<IActionResult> Index()
        {
            var staLuciaContext = _context.PedidoMenus.Include(p => p.MenuNavigation).Include(p => p.PedidoNavigation);
            return View(await staLuciaContext.ToListAsync());
        }

        // GET: PedidoMenus/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoMenus = await _context.PedidoMenus
                .Include(p => p.MenuNavigation)
                .Include(p => p.PedidoNavigation)
                .FirstOrDefaultAsync(m => m.Pedido == id);
            if (pedidoMenus == null)
            {
                return NotFound();
            }

            return View(pedidoMenus);
        }

        // GET: PedidoMenus/Create
        public IActionResult Create()
        {
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id");
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id");
            return View();
        }

        // POST: PedidoMenus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pedido,Menu")] PedidoMenus pedidoMenus)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidoMenus);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", pedidoMenus.Menu);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", pedidoMenus.Pedido);
            return View(pedidoMenus);
        }

        // GET: PedidoMenus/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoMenus = await _context.PedidoMenus.FindAsync(id);
            if (pedidoMenus == null)
            {
                return NotFound();
            }
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", pedidoMenus.Menu);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", pedidoMenus.Pedido);
            return View(pedidoMenus);
        }

        // POST: PedidoMenus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Pedido,Menu")] PedidoMenus pedidoMenus)
        {
            if (id != pedidoMenus.Pedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidoMenus);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoMenusExists(pedidoMenus.Pedido))
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
            ViewData["Menu"] = new SelectList(_context.Menu, "Id", "Id", pedidoMenus.Menu);
            ViewData["Pedido"] = new SelectList(_context.Pedido, "Id", "Id", pedidoMenus.Pedido);
            return View(pedidoMenus);
        }

        // GET: PedidoMenus/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidoMenus = await _context.PedidoMenus
                .Include(p => p.MenuNavigation)
                .Include(p => p.PedidoNavigation)
                .FirstOrDefaultAsync(m => m.Pedido == id);
            if (pedidoMenus == null)
            {
                return NotFound();
            }

            return View(pedidoMenus);
        }

        // POST: PedidoMenus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidoMenus = await _context.PedidoMenus.FindAsync(id);
            _context.PedidoMenus.Remove(pedidoMenus);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoMenusExists(int id)
        {
            return _context.PedidoMenus.Any(e => e.Pedido == id);
        }
    }
}
