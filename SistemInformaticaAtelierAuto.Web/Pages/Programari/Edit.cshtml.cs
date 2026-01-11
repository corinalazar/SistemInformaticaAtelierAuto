using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SistemInformaticaAtelierAuto.Web.Data;
using SistemInformaticaAtelierAuto.Web.Models;

namespace SistemInformaticaAtelierAuto.Web.Pages.Programari
{
    public class EditModel : PageModel
    {
        private readonly SistemInformaticaAtelierAuto.Web.Data.SistemInformaticaAtelierAutoWebContext _context;

        public EditModel(SistemInformaticaAtelierAuto.Web.Data.SistemInformaticaAtelierAutoWebContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Programare Programare { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programare =  await _context.Programari.FirstOrDefaultAsync(m => m.Id == id);
            if (programare == null)
            {
                return NotFound();
            }
            Programare = programare;
           ViewData["CarId"] = new SelectList(_context.Cars, "ID", "ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Programare).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramareExists(Programare.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProgramareExists(int id)
        {
            return _context.Programari.Any(e => e.Id == id);
        }
    }
}
