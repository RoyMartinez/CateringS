using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Catering_Santa_Lucia.Data;
using Catering_Santa_Lucia.Models;
//using System.Linq;

namespace Catering_Santa_Lucia.Controllers
{
    public class PedidosController : Controller
    {
        private readonly StaLuciaContext _context;

        public PedidosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var staLuciaContext = _context.Pedido.Include(p => p.ClienteNavigation).Include(p => p.TipoNavigation).Include(p => p.UsuarioNavigation);
            return View(await staLuciaContext.ToListAsync());
        }
        // GET: Pedidos
        public async Task<IActionResult> IndexGeneral()
        {
            var staLuciaContext = _context.Pedido.Include(p => p.ClienteNavigation).Include(p => p.TipoNavigation).Include(p => p.UsuarioNavigation);
            //List<Pedido> Datos = staLuciaContext.ToList();
            //List<Pedido> Pedido_Usuario = (from Data in Datos
            //                               where Data.Cliente == Globales.Id
            //                               select new Pedido
            //                               {
            //                                   Id = Data.Id,
            //                                   FechaCreacion = Data.FechaCreacion,
            //                                   FechaPedido = Data.FechaPedido,
            //                                   Tipo = Data.Tipo,
            //                                   Cliente = Data.Cliente,
            //                                   Usuario = Data.Usuario
            //                               }).ToList();
            return View(await staLuciaContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.ClienteNavigation)
                .Include(p => p.TipoNavigation)
                .Include(p => p.UsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        // GET: Pedidos/Details/5
        public async Task<IActionResult> DetailsGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.ClienteNavigation)
                .Include(p => p.TipoNavigation)
                .Include(p => p.UsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre");
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion");
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre");
            return View();
        }
        // GET: Pedidos/Create
        public IActionResult CreateGeneral()
        {
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre");
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion");
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FechaCreacion,FechaPedido,Tipo,Cliente,Usuario")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }
        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateGeneral([Bind("Id,FechaCreacion,FechaPedido,Tipo,Cliente,Usuario")] Pedido pedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(IndexGeneral));
            }
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }
        // GET: Pedidos/Edit/5
        public async Task<IActionResult> EditGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FechaCreacion,FechaPedido,Tipo,Cliente,Usuario")] Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
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
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }


        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditGeneral(int id, [Bind("Id,FechaCreacion,FechaPedido,Tipo,Cliente,Usuario")] Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
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
            ViewData["Cliente"] = new SelectList(_context.Cliente, "Id", "Nombre", pedido.Cliente);
            ViewData["Tipo"] = new SelectList(_context.TipoPedido, "Id", "Descripcion", pedido.Tipo);
            ViewData["Usuario"] = new SelectList(_context.Usuario, "Id", "Nombre", pedido.Usuario);
            return View(pedido);
        }


        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.ClienteNavigation)
                .Include(p => p.TipoNavigation)
                .Include(p => p.UsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }
        // GET: Pedidos/Delete/5
        public async Task<IActionResult> DeleteGeneral(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedido
                .Include(p => p.ClienteNavigation)
                .Include(p => p.TipoNavigation)
                .Include(p => p.UsuarioNavigation)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("DeleteGeneral")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedGeneral(int id)
        {
            var pedido = await _context.Pedido.FindAsync(id);
            _context.Pedido.Remove(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(IndexGeneral));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedido.Any(e => e.Id == id);
        }
    }
}
