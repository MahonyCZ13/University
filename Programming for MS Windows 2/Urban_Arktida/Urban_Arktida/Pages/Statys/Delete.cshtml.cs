using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Urban_Arktida.Models;

namespace Urban_Arktida.Pages.Statys
{
    public class DeleteModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public DeleteModel(Urban_Arktida.Models.ArktidaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Staty Staty { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Staty = await _context.Staty.FirstOrDefaultAsync(m => m.Cid == id);

            if (Staty == null)
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

            Staty = await _context.Staty.FindAsync(id);

            if (Staty != null)
            {
                _context.Staty.Remove(Staty);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
