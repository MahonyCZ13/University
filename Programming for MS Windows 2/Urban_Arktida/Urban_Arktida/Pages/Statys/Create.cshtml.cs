using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Urban_Arktida.Models;

namespace Urban_Arktida.Pages.Statys
{
    public class CreateModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public CreateModel(Urban_Arktida.Models.ArktidaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Staty Staty { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Staty.Add(Staty);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
