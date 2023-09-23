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
    public class DetailsModel : PageModel
    {
        private readonly practicaEmpleado.Data.practicaEmpleadoContext _context;

        public DetailsModel(practicaEmpleado.Data.practicaEmpleadoContext context)
        {
            _context = context;
        }

      public Bono Bono { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bono == null)
            {
                return NotFound();
            }

            var bono = await _context.Bono.FirstOrDefaultAsync(m => m.ID == id);
            if (bono == null)
            {
                return NotFound();
            }
            else 
            {
                Bono = bono;
            }
            return Page();
        }
    }
}
