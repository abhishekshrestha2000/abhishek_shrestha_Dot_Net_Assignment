using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Abhishek_Dot_net_Assignment.Data;
using Abhishek_Dot_net_Assignment.Models;

namespace Abhishek_Dot_net_Assignment.Controllers
{
    public class EnrollsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EnrollsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Enrolls
        public async Task<IActionResult> Index()
        {
            return View(await _context.Enroll.ToListAsync());
        }

        // GET: Enrolls/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enroll
                .FirstOrDefaultAsync(m => m.EnrollId == id);
            if (enroll == null)
            {
                return NotFound();
            }

            return View(enroll);
        }

        // GET: Enrolls/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Enrolls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EnrollId,StudentId,CourseId,EnrollmentDate,Status,IsPaid")] Enroll enroll)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enroll);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(enroll);
        }

        // GET: Enrolls/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enroll.FindAsync(id);
            if (enroll == null)
            {
                return NotFound();
            }
            return View(enroll);
        }

        // POST: Enrolls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EnrollId,StudentId,CourseId,EnrollmentDate,Status,IsPaid")] Enroll enroll)
        {
            if (id != enroll.EnrollId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enroll);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollExists(enroll.EnrollId))
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
            return View(enroll);
        }

        // GET: Enrolls/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enroll = await _context.Enroll
                .FirstOrDefaultAsync(m => m.EnrollId == id);
            if (enroll == null)
            {
                return NotFound();
            }

            return View(enroll);
        }

        // POST: Enrolls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enroll = await _context.Enroll.FindAsync(id);
            if (enroll != null)
            {
                _context.Enroll.Remove(enroll);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollExists(int id)
        {
            return _context.Enroll.Any(e => e.EnrollId == id);
        }
    }
}
