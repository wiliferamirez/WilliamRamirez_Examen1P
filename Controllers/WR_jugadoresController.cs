using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WilliamRamirez_Examen1P.Data;
using WilliamRamirez_Examen1P.Models;

namespace WilliamRamirez_Examen1P.Controllers
{
    public class WR_jugadoresController : Controller
    {
        private readonly WilliamRamirez_Examen1PContext _context;

        public WR_jugadoresController(WilliamRamirez_Examen1PContext context)
        {
            _context = context;
        }

        // GET: WR_jugadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.WR_jugadores.ToListAsync());
        }

        // GET: WR_jugadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_jugadores = await _context.WR_jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wR_jugadores == null)
            {
                return NotFound();
            }

            return View(wR_jugadores);
        }

        // GET: WR_jugadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WR_jugadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nombre,apellido,edad,dorsal,activo,fechaInscripcion,sueldo")] WR_jugadores wR_jugadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wR_jugadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wR_jugadores);
        }

        // GET: WR_jugadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_jugadores = await _context.WR_jugadores.FindAsync(id);
            if (wR_jugadores == null)
            {
                return NotFound();
            }
            return View(wR_jugadores);
        }

        // POST: WR_jugadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nombre,apellido,edad,dorsal,activo,fechaInscripcion,sueldo")] WR_jugadores wR_jugadores)
        {
            if (id != wR_jugadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wR_jugadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WR_jugadoresExists(wR_jugadores.Id))
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
            return View(wR_jugadores);
        }

        // GET: WR_jugadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_jugadores = await _context.WR_jugadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wR_jugadores == null)
            {
                return NotFound();
            }

            return View(wR_jugadores);
        }

        // POST: WR_jugadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wR_jugadores = await _context.WR_jugadores.FindAsync(id);
            if (wR_jugadores != null)
            {
                _context.WR_jugadores.Remove(wR_jugadores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WR_jugadoresExists(int id)
        {
            return _context.WR_jugadores.Any(e => e.Id == id);
        }
    }
}
