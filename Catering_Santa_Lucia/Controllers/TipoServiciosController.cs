﻿using System;
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
    public class TipoServiciosController : Controller
    {
        private readonly StaLuciaContext _context;

        public TipoServiciosController(StaLuciaContext context)
        {
            _context = context;
        }

        // GET: TipoServicios
        public async Task<IActionResult> Index()
        {
            return View(await _context.TipoServicio.ToListAsync());
        }

        // GET: TipoServicios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoServicio == null)
            {
                return NotFound();
            }

            return View(tipoServicio);
        }

        // GET: TipoServicios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipoServicios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Descripcion")] TipoServicio tipoServicio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tipoServicio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tipoServicio);
        }

        // GET: TipoServicios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicio.FindAsync(id);
            if (tipoServicio == null)
            {
                return NotFound();
            }
            return View(tipoServicio);
        }

        // POST: TipoServicios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Descripcion")] TipoServicio tipoServicio)
        {
            if (id != tipoServicio.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tipoServicio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TipoServicioExists(tipoServicio.Id))
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
            return View(tipoServicio);
        }

        // GET: TipoServicios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tipoServicio = await _context.TipoServicio
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tipoServicio == null)
            {
                return NotFound();
            }

            return View(tipoServicio);
        }

        // POST: TipoServicios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tipoServicio = await _context.TipoServicio.FindAsync(id);
            _context.TipoServicio.Remove(tipoServicio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TipoServicioExists(int id)
        {
            return _context.TipoServicio.Any(e => e.Id == id);
        }
    }
}
