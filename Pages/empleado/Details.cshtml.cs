using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using practicaEmpleado.Data;
using practicaEmpleado.Modelo;

namespace practicaEmpleado.Pages.empleado
{
    public class DetailsModel : PageModel
    {
        private readonly practicaEmpleado.Data.practicaEmpleadoContext _context;

        public DetailsModel(practicaEmpleado.Data.practicaEmpleadoContext context)
        {
            _context = context;
        }

      public Empleado Empleado { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Empleado == null)
            {
                return NotFound();
            }

            var empleado = await _context.Empleado.FirstOrDefaultAsync(m => m.ID == id);
            if (empleado == null)
            {
                return NotFound();
            }
            else 
            {
                Empleado = empleado;
            }
            return Page();
        }
    }
}
