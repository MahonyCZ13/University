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
    public class DetailsModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public DetailsModel(Urban_Arktida.Models.ArktidaContext context)
        {
            _context = context;
        }

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
    }
}
