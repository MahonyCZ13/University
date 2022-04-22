using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Urban_Arktida.Models;

namespace Urban_Arktida.Pages.Statys
{
    public class EditModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public EditModel(Urban_Arktida.Models.ArktidaContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Staty).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatyExists(Staty.Cid))
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

        private bool StatyExists(int id)
        {
            return _context.Staty.Any(e => e.Cid == id);
        }
    }
}
