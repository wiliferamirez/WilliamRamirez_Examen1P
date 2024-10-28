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
    public class WR_Sub18Controller : Controller
    {
        private readonly WilliamRamirez_Examen1PContext _context;

        public WR_Sub18Controller(WilliamRamirez_Examen1PContext context)
        {
            _context = context;
        }

        // GET: WR_Sub18
        public async Task<IActionResult> Index()
        {
            return View(await _context.WR_Sub18.ToListAsync());
        }

        // GET: WR_Sub18/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_Sub18 = await _context.WR_Sub18
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wR_Sub18 == null)
            {
                return NotFound();
            }

            return View(wR_Sub18);
        }

        // GET: WR_Sub18/Create
        public IActionResult Create()
        {
            return View("WR_Create");
        }

        // POST: WR_Sub18/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,WR_nombre,WR_apellido,WR_edad,WR_dorsal,WR_activo,WR_fechaInscripcion,WR_sueldo")] WR_Sub18 wR_Sub18)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wR_Sub18);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wR_Sub18);
        }

        // GET: WR_Sub18/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_Sub18 = await _context.WR_Sub18.FindAsync(id);
            if (wR_Sub18 == null)
            {
                return NotFound();
            }
            return View(wR_Sub18);
        }

        // POST: WR_Sub18/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,WR_nombre,WR_apellido,WR_edad,WR_dorsal,WR_activo,WR_fechaInscripcion,WR_sueldo")] WR_Sub18 wR_Sub18)
        {
            if (id != wR_Sub18.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wR_Sub18);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WR_Sub18Exists(wR_Sub18.Id))
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
            return View(wR_Sub18);
        }

        // GET: WR_Sub18/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wR_Sub18 = await _context.WR_Sub18
                .FirstOrDefaultAsync(m => m.Id == id);
            if (wR_Sub18 == null)
            {
                return NotFound();
            }

            return View(wR_Sub18);
        }

        // POST: WR_Sub18/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wR_Sub18 = await _context.WR_Sub18.FindAsync(id);
            if (wR_Sub18 != null)
            {
                _context.WR_Sub18.Remove(wR_Sub18);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WR_Sub18Exists(int id)
        {
            return _context.WR_Sub18.Any(e => e.Id == id);
        }
    }
}
