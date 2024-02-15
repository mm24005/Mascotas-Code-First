using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CFMASCOTASNDMM.Models;

namespace CFMascotasNDMM.Controllers
{
    public class MascotasController : Controller
    {
        private readonly MascotasContext _context;

        public MascotasController(MascotasContext context)
        {
            _context = context;
        }

        // GET: Mascotas
        public async Task<IActionResult> Index()
        {
            return View(await _context.mascotas.ToListAsync());
        }

        // GET: Mascotas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.mascotas
                .FirstOrDefaultAsync(m => m.Idmascotas == id);
            if (mascotas == null)
            {
                return NotFound();
            }

            return View(mascotas);
        }

        // GET: Mascotas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Mascotas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Idmascotas,Nombre,Especie,Propietario")] Mascotas mascotas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mascotas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mascotas);
        }

        // GET: Mascotas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.mascotas.FindAsync(id);
            if (mascotas == null)
            {
                return NotFound();
            }
            return View(mascotas);
        }

        // POST: Mascotas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Idmascotas,Nombre,Especie,Propietario")] Mascotas mascotas)
        {
            if (id != mascotas.Idmascotas)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mascotas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MascotasExists(mascotas.Idmascotas))
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
            return View(mascotas);
        }

        // GET: Mascotas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mascotas = await _context.mascotas
                .FirstOrDefaultAsync(m => m.Idmascotas == id);
            if (mascotas == null)
            {
                return NotFound();
            }

            return View(mascotas);
        }

        // POST: Mascotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mascotas = await _context.mascotas.FindAsync(id);
            if (mascotas != null)
            {
                _context.mascotas.Remove(mascotas);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MascotasExists(int id)
        {
            return _context.mascotas.Any(e => e.Idmascotas == id);
        }
    }
}
