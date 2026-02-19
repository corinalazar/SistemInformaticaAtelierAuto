using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SistemInformaticaAtelierAuto.Web.Data;
using SistemInformaticaAtelierAuto.Web.Models;

namespace SistemInformaticaAtelierAuto.Web.Pages.Programari
{
    public class DeleteModel : PageModel
    {
        private readonly SistemInformaticaAtelierAuto.Web.Data.SistemInformaticaAtelierAutoWebContext _context;

        public DeleteModel(SistemInformaticaAtelierAuto.Web.Data.SistemInformaticaAtelierAutoWebContext context)
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

            var programare = await _context.Programari.FirstOrDefaultAsync(m => m.Id == id);

            if (programare == null)
            {
                return NotFound();
            }
            else
            {
                Programare = programare;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programare = await _context.Programari.FindAsync(id);
            if (programare != null)
            {
                Programare = programare;
                _context.Programari.Remove(Programare);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
