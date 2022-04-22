using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Urban_Arktida.Models;

namespace Urban_Arktida.Pages.Mestys
{
    public class EditModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public EditModel(Urban_Arktida.Models.ArktidaContext context)
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
           ViewData["Cid"] = new SelectList(_context.Staty, "Cid", "Cid");
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

            _context.Attach(Mesta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MestaExists(Mesta.Mid))
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

        private bool MestaExists(int id)
        {
            return _context.Mesta.Any(e => e.Mid == id);
        }
    }
}
