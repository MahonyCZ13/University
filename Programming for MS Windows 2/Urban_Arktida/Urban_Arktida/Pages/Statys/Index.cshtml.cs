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
    public class IndexModel : PageModel
    {
        private readonly Urban_Arktida.Models.ArktidaContext _context;

        public IndexModel(Urban_Arktida.Models.ArktidaContext context)
        {
            _context = context;
        }

        public IList<Staty> Staty { get;set; }

        public async Task OnGetAsync()
        {
            Staty = await _context.Staty.ToListAsync();
        }
    }
}
