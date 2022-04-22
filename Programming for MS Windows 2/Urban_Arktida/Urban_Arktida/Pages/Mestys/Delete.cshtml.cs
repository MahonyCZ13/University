using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urban_Arktida.Models;

namespace Urban_Arktida.Pages.Mestys
{
    public class DeleteModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public DeleteModel(Urban_Arktida.Models.ArktidaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Mesta Mesta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mesta = await _context.Mesta
                .Include(m => m.C).FirstOrDefaultAsync(m => m.Mid == id);

            if (Mesta == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Mesta = await _context.Mesta.FindAsync(id);

            if (Mesta != null)
            {
                _context.Mesta.Remove(Mesta);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
