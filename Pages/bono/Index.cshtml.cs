using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using practicaEmpleado.Data;
using practicaEmpleado.Modelo;

namespace practicaEmpleado.Pages.bono
{
    public class IndexModel : PageModel
    {
        private readonly practicaEmpleado.Data.practicaEmpleadoContext _context;

        public IndexModel(practicaEmpleado.Data.practicaEmpleadoContext context)
        {
            _context = context;
        }

        public IList<Bono> Bono { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Bono != null)
            {
                Bono = await _context.Bono.ToListAsync();
            }
        }
    }
}
